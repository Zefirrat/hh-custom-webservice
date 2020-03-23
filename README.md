# Astral test (HeadHunter WebService)
### Description
Project that uses the headhunter api for getting and storing some information for some reasons

### Quick start

$ cd VacanciesService
$ docker build -t vacanciesservice .
$ docker run -d -p 8080:80 --name myapp vacanciesservice

### Explaining

After run main solution VacanciesService test endpoint in https://localhost:5001/ActualVacancies

There you will get base response of HH api.

To search on this loaded vacancies do the query https://localhost:5001/ActualVacancies/searchByName?searchstring=*SEARCH_QUERY*

Where *SEARCH_QUERY* is the query that contains in names of vacancies. NO REGEX.
