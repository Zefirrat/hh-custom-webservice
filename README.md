# Astral test (HeadHunter WebService)
### Description
Project that uses the headhunter api for getting and storing some information for some reasons

### Quick start

> $ cd VacanciesService

> $ dotnet build VacanciesService.sln

> $ dotnet VacanciesService\bin\Debug\netcoreapp3.1\VacanciesService.dll

Navigate with broser to https://localhost:5001/ActualVacancies

OR

Navigate to https://localhost:5001/index.html to see the **Swagger** info

### Explaining

After run main solution VacanciesService test endpoint in https://localhost:5001/ActualVacancies

There you will get base response of HH api.

To search on this loaded vacancies do the query https://localhost:5001/ActualVacancies/searchByName?searchstring=*SEARCH_QUERY*

Where *SEARCH_QUERY* is the query that contains in names of vacancies. NO REGEX.

#### PS
There might be the docker host realisation, but my PC does not support Virtualisation in BIOS, but it not so dificult I think, like two commands *docker build* and *docker run* (added Dockerfile to the root folder as Example)
