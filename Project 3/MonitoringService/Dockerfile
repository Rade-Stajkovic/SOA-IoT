FROM node:alpine
WORKDIR /usr/src/app
COPY ./MonitoringService/package*.json .
RUN npm install
COPY ./MonitoringServices .
EXPOSE 3000
CMD ["node", "monitoring.js"]