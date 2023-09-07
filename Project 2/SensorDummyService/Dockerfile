FROM node:alpine
WORKDIR /usr/src/app
COPY ./SensorDummyService/package*.json .
RUN npm install
COPY ./SensorDummyService .
EXPOSE 3000
CMD ["node", "mqtt_publisher.js"]