from math import sin, cos, sqrt, atan2, radians
import folium
import MySQLdb
import queue as Q
import sys
import os
from datetime import datetime

now = datetime.now()
di = {0:'Monday' , 1:'Tuesday' , 2:'Wednesday' , 3:'Thursday' , 4:'Friday' , 5:'Saturday' , 6:'Sunday'}
day = di[datetime.today().weekday()]
print (now.hour,now.minute,now.second)
args = sys.argv
_,source,dest = args
db = MySQLdb.connect(host="localhost",    # your host, usually localhost
                     user="root",         # your username
                     passwd="akshay", 	  # your password
                     db="dbslab")        # name of the data base

def get_location(cur,name):
	query = 'SELECT latitude,longitude from location where lname = \'{0}\' ;'.format(name)
	cur.execute(query)
	return list(map(float,cur.fetchall()[0]))

def get_dist(cur,source,dest):
	R = 6373.0
	s = get_row(cur,source)
	d = get_row(cur,dest)
	
	lat1 = radians(float(s[1]))
	lon1 = radians(float(s[2]))
	lat2 = radians(float(d[1]))
	lon2 = radians(float(d[2]))

	dlon = lon2 - lon1
	dlat = lat2 - lat1

	a = sin(dlat / 2)**2 + cos(lat1) * cos(lat2) * sin(dlon / 2)**2
	c = 2 * atan2(sqrt(a), sqrt(1 - a))
	return R * c #In Km

def get_neighbours(cur,source):
	query = 'SELECT * FROM location where lname in ( select neighLoc from neighbour where currLoc= \'' + source + '\') OR lname in ( select currLoc from neighbour where neighLoc= \'' + source + '\');'
	cur.execute(query)
	neighbours =  cur.fetchall()
	return neighbours

def get_time(cur,source,dest):
	if source == dest:
		return 0	
	query = 'SELECT traveltime from neighbour where (currLoc = \'{0}\' and neighLoc = \'{1}\') or (currLoc = \'{1}\' and neighLoc = \'{0}\');'.format(source,dest)
	cur.execute(query)
	#print ('Finding time between {0} and {1}'.format(source,dest))
	time = cur.fetchall()
	time = float(time[0][0].split()[0])
	return time

def get_row(cur,name):
	query = 'SELECT * FROM location where lname =\'{0}\';'.format(name)
	cur.execute(query)
	return cur.fetchall()[0]
def  get_et(cur,dest ,day):
	if(dest == '313' or dest == 'Lab8' or dest == 'Lab1'):
		query = 'SELECT timeSlot , subject from schedule where room = \'{0}\' and day =\'{1}\' ;'.format(dest , day)
		cur.execute(query)
		ts = cur.fetchall()
		return ts
	else:
		print('Destination Is Not A class or lab')
		return ()
path = []
cur = db.cursor()
#query = 'SELECT * FROM location where location.lname=\''+source+'\';'
#cur.execute('SELECT * FROM location where location.lname=\''+source+'\';')
#row = cur.fetchall()[0]
#lat,lon = row[1],row[2]
#path.append((lat,lon))

#A* Algorithm
Open = Q.PriorityQueue()
Open.put(source,0)
came_from = {}
cost_so_far = {}
came_from[source] = None
cost_so_far[source] = 0

while not Open.empty():
	current = Open.get()
	#print (current)
	if current == dest:
		#Found goal
		pass
	neighbours = get_neighbours(cur,current)
	#print (current,':',neighbours)
	for next in neighbours:
		time = get_time(cur,current,next[0])		
		new_cost = cost_so_far[current] + get_dist(cur,current,next[0])	
		if next[0] not in cost_so_far or new_cost < cost_so_far[next[0]]:
			cost_so_far[next[0]] = new_cost
			priority = new_cost + get_dist(cur,next[0],dest)
			Open.put(next[0],priority)
			came_from[next[0]] = current

			
#Reconstruct path
current = dest
while current!=source:
	#print (current)
	path.append(current)	
	current = came_from[current]
path.append(current)	

#print ('Path : ',path[::-1])
#print ('Estimated Time : '+ str(cost_so_far[dest]) + ' min')
dist = 0
for i in range(len(path)-1):
	dist+=get_dist(cur,path[i],path[i+1])
print ('Distance : '+ '{0:0.4f}'.format(dist*1000) + 'm')	
print ('Estimated Time : '+ '{0:0.0f}'.format(dist*1000/(1.4*60)) + ' min')	
ts = get_et(cur , dest , day)
t = None
s = None
for i in range(len(ts)):
	t = ts[i][0].split('-')[0]
	class_time = datetime.now().replace(hour = int(t.split(':')[0]),minute=int(t.split(':')[1]), second = 0 , microsecond = 0)
	s = ts[i][1]
	if class_time.time() > now.time():
		print('{0} class is there at {1}'.format(s,class_time.time()))
		#print(class_time , now)
		expected_time = datetime.now().replace(minute = int(dist*1000/(1.4*60)))
		time_diff = class_time- now
		#print(time_diff.total_seconds()) 
		#print(time_diff.total_seconds(),expected_time.minute*60)
		if time_diff.total_seconds() < expected_time.minute*60 :
			print('You are late for {0} class by {1} minutes!!'.format(s,time_diff.total_seconds()/60 - expected_time.minute))
		break 		

else:
	print('No classes now!')


coordinates = [get_location(cur,name) for name in path]
#print ('Coordinates : ',coordinates)

map_osm = folium.Map(location=[13.3521, 74.793],zoom_start=16)
folium.PolyLine(coordinates,line_color='#FF0000', line_weight=5).add_to(map_osm)
#print(os.getcwd()
for loc,name in zip(coordinates,path):
	folium.Marker(loc,popup=name).add_to(map_osm)

map_osm.save('manipal_map.html')
	
#print ('Map made')




