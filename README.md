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

### postcodeage-{date}.json

Each data record contains the following info
- Postcode
- Total dose administered
- Number of Dose 1
- Number of Dose 2
- Age group of people that received the doses

### suburb-{date}.json

Each data record contains the following info
- Suburb name
- Total dose administered
- Number of Dose 1
- Number of Dose 2

### suburbage-{date}.json

Each data record contains the following info
- Suburb name
- Total dose administered
- Number of Dose 1
- Number of Dose 2
- Age group of people that received the doses

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

### dosesage.json

Each data record contains the following info
- Date 
- Age group for the for the doses on that date
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

Contains data for every date, suburb, postcode and group combination with the exact doses performed (dose 1, 2 and total)
- Date
- Suburb
- Postcode
- Dose 1
- Dose 2
- Total vaccines
- Age group

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

Note the files under the dailyage folder are the same as the daily folder, but with additional age group split data

### rollavg.json

The 7 day rolling average of the total doses per day
 - Date
 - 7 day total dose rolling average

### rollavgage.json

The 7 day rolling average of the total doses per day split by age group
 - Date
 - 7 day total dose rlling average
 - age group

### rollavgfirstsecond.json

7 day rolling average for each of dose 1,dose 2 and total
 - Date
 - total dose rolling average
 - Dose 1 rolling average
 - Dose 2 rolling average

### rollavgfirstsecondage.json

7 day rolling average for each of dose 1,dose 2 and total split by age group
 - Date
 - Age Group
 - total dose rolling average
 - Dose 1 rolling average
 - Dose 2 rolling average
