# dealstoreweb.frontend


// es ist möglich das image ohne build-arg zu deployen
docker build  -t fernlehre_v8 .

docker build --build-arg VUE_APP_ROOT_API=http://3.83.137.226:8080  -t fernlehre_v7 .

docker run --name fernlehr1 --rm -it  -p 8090:8080  -e VUE_APP_ROOT_API=http://3.83.137.226:8080 -d fernlehre_v7

//tag you image to push
docker tag 943e0a6f95d7 adlolab/dealstore_frontend:v1

//Docker push
docker push adlolab/dealstore_frontend:v1

//Push steps to docker hub:
    Step 1: build
    cmd: docker build  -t dealstore_frontend:v2 .

    step 2: write tag to created image 
    cmd: docker tag defe83e3b094  adlolab/dealstore_frontend:v2
    
    step 3: push this image
    cmd: docker push adlolab/dealstore_frontend:v2
	
## Project setup
```
npm install
```

### Compiles and hot-reloads for development
```
npm run serve
```

### Compiles and minifies for production
```
npm run build
```

### Lints and fixes files
```
npm run lint
```

### Customize configuration
See [Configuration Reference](https://cli.vuejs.org/config/).


