# WAVaccine-Stats

This code pulls in details from the WA (Western Australia) Health dashboard for the COVID-19 vaccine rollout

JSON files can be found in the data folder

## Notes

### postcode-{date}.json

Each data record contains the following info
- Postcode
- Total dose administered
- Number of Dose 1
- Number of Dose 2

### suburb-{date}.json

Each data record contains the following info
- Suburb name
- Total dose administered
- Number of Dose 1
- Number of Dose 2

### timeline.json

Each data record contains the following info
- Date 
- Number of people with 2 doses as of the date
- Number of people with exactly 1 dose as of the date
- Number of unique people vaccinated (aka number of people with at least 1 dose)
