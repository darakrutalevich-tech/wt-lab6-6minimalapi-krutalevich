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

&#x20; {

&#x20;   "id": 1,

&#x20;   "flightNumber": "AV-101",

&#x20;   "departure": "Минск",

&#x20;   "arrival": "Варшава",

&#x20;   "price": 250,

&#x20;   "isAvailable": true

&#x20; }

]

```



\### GET /api/flights/{id}



Запрос:



&#x20;   GET /api/flights/1



Ответ (200):



```json

{

&#x20; "id": 1,

&#x20; "flightNumber": "AV-101",

&#x20; "departure": "Минск",

&#x20; "arrival": "Варшава",

&#x20; "price": 250,

&#x20; "isAvailable": true

}

```



Ответ (404), если рейс не найден: пустое тело.



\### POST /api/flights



Запрос:



```json

{

&#x20; "flightNumber": "AV-606",

&#x20; "departure": "Минск",

&#x20; "arrival": "Прага",

&#x20; "price": 300,

&#x20; "isAvailable": true

}

```



Ответ (201 Created), заголовок `Location: /api/flights/6`:



```json

{

&#x20; "id": 6,

&#x20; "flightNumber": "AV-606",

&#x20; "departure": "Минск",

&#x20; "arrival": "Прага",

&#x20; "price": 300,

&#x20; "isAvailable": true

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

&#x20; "flightNumber": "AV-101-NEW",

&#x20; "departure": "Минск",

&#x20; "arrival": "Краков",

&#x20; "price": 280,

&#x20; "isAvailable": true

}

```



Ответ (200): обновлённый объект.



\### DELETE /api/flights/{id}



Запрос:



&#x20;   DELETE /api/flights/2



Ответ (204 No Content): пустое тело.

