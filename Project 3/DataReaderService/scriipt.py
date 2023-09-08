import requests
import json
import random
import time
import csv


i = 0

if __name__ == "__main__":

    with open("./AirPi Data - AirPi.csv", 'r') as file:
        csvreader = csv.reader(file) 
        for row in csvreader:
            
            if i == 0: 
                i = i + 1
                continue

            url = 'http://172.26.176.1:49986/api/v1/resource/SensorValueCluster2/nitrogendioxide'
            print(row[-1])
            payload = int(float(row[-1]))
            headers = {'content-type': 'application/json'}
            response = requests.post(url, data=json.dumps(payload), headers=headers, verify=False)
            print(response)

            time.sleep(5)