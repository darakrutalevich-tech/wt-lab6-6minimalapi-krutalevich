\# WT-6 — REST API: Авиакомпания

Круталевич Д.В.



Репозиторий: https://github.com/darakrutalevich-tech/wt-lab6-6minimalapi-krutalevich

Render: 



\## API endpoints



| Метод  | URL                 | Назначение       |

|--------|---------------------|------------------|

| GET    | /api/flights        | получить список  |

| GET    | /api/flights/{id}   | получить объект  |

| POST   | /api/flights        | создать объект   |

| PUT    | /api/flights/{id}   | изменить объект  |

| DELETE | /api/flights/{id}   | удалить объект   |



\## HTTP-статусы



\- 200 OK — успешный GET / PUT

\- 201 Created — успешный POST

\- 204 No Content — успешный DELETE

\- 400 Bad Request — некорректные данные

\- 404 Not Found — объект не найден



\## Примеры



\### GET /api/flights



Запрос:



&#x20;   GET /api/flights



Ответ (200):



```json

\[

 {

   "id": 1,

   "flightNumber": "AV-101",

   "departure": "Минск",

   "arrival": "Варшава",

   "price": 250,

   "isAvailable": true

 }

]

```



\### GET /api/flights/{id}



Запрос:



   GET /api/flights/1



Ответ (200):



```json

{

 "id": 1,

 "flightNumber": "AV-101",

 "departure": "Минск",

 "arrival": "Варшава",

 "price": 250,

 "isAvailable": true

}

```



Ответ (404), если рейс не найден: пустое тело.



\### POST /api/flights



Запрос:



```json

{

 "flightNumber": "AV-606",

 "departure": "Минск",

 "arrival": "Прага",

 "price": 300,

 "isAvailable": true

}

```



Ответ (201 Created), заголовок `Location: /api/flights/6`:



```json

{

 "id": 6,

 "flightNumber": "AV-606",

 "departure": "Минск",

 "arrival": "Прага",

 "price": 300,

 "isAvailable": true

}

```



Ответ (400), если поля пустые или цена ≤ 0:



```json

{ "error": "Некорректные данные" }

```



\### PUT /api/flights/{id}



Запрос:



```json

{

 "flightNumber": "AV-101-NEW",

 "departure": "Минск",

 "arrival": "Краков",

 "price": 280,

 "isAvailable": true

}

```



Ответ (200): обновлённый объект.



\### DELETE /api/flights/{id}



Запрос:



   DELETE /api/flights/2



Ответ (204 No Content): пустое тело.

