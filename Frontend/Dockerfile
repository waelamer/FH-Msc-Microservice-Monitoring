FROM node:lts-alpine


# install simple http server for serving static content
RUN npm install -g http-server

#Install Telegraf
RUN apk update
RUN apk add telegraf
#RUN telegraf --config /app/telegraf/telegraf.conf
# CMD ["telegraf", "--config", "/app/telegraf/telegraf.conf"]

#CMD ["apk", "update"]
#CMD ["apk", "add" , "telegraf"]

# CMD ["telegraf", "--config", "/app/telegraf/telegraf.conf"]

#Install Promtail

RUN mkdir app
# make the 'app' folder the current working directory
WORKDIR /app

# copy both 'package.json' and 'package-lock.json' (if available)
COPY package*.json ./

# install project dependencies
RUN npm install
#cross-env makes it so you can have a single command without worrying about setting
#using the environment variable properly for the platform
RUN npm i cross-env

# copy project files and folders to the current working directory (i.e. 'app' folder)
COPY . .

# define argument 
ARG VUE_APP_ROOT_API_P
ENV VUE_APP_ROOT_API_P $VUE_APP_ROOT_API_P

ARG VUE_APP_ROOT_API_D
ENV VUE_APP_ROOT_API_D $VUE_APP_ROOT_API_D

# build app for production with minification
#RUN npm run build

EXPOSE 8080
#CMD [ "http-server", "dist" ]
CMD ["npm", "run", "serve", "--mode=production"]


