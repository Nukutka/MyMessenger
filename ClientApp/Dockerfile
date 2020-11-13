FROM node:14.8.0-stretch-slim

WORKDIR /usr/src/ClientApp/

EXPOSE 4200

ENV PATH ./node_modules/.bin:$PATH

COPY package.json ./package.json
RUN npm install
RUN npm install -g @angular/cli

COPY . .

CMD ng serve --host 0.0.0.0