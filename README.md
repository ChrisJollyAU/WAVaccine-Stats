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

### doses.json

Each data record contains the following info
- Date 
- Total doses administered on that date
- Numboer of dose 1's administered on that date
- Numboer of dose 2's administered on that date

### sa2summary-{date}.json

Summarises details at the SA2 (Statistical Area 2) level
Contains the following info
- SA2 Name
- Number aged 16 and over
- Total number of dose 1's for the region
- Total number of dose 2's for the region
- Total number of doses for the region
- Percent of region with at least 1 dose
- Percent of region fully vaccinated

### daily/all.json

Contains data for every date, suburb and postcode combination with the exact doses performed (dose 1, 2 and total)
- Date
- Suburb
- Postcode
- Dose 1
- Dose 2
- Total vaccines

### daily/postcode/{postcode}.json
File for every postcode in WA. Contains data for each day there were doses administered for that postcode
- Date
- Postcode
- Dose 1
- Dose 2
- Total vaccines

### daily/suburb/{suburb}.json
File for every suburb in WA. Contains data for each day there were doses administered for that suburb
- Date
- Suburb
- Dose 1
- Dose 2
- Total vaccines
