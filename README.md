# coreangular-test

my personal tests with .net Core and Angular

swagger: http://localhost:5000/swagger/index.html


#Generate Api Code
Download CLI from here: https://github.com/swagger-api/swagger-codegen
java -jar swagger-codegen-cli-2.2.2.jar generate -i http://localhost:5000/swagger/v1/swagger.json -l typescript-angular2 -o export/angular2
