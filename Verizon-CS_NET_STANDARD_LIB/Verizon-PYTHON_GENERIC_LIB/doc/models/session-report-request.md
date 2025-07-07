
# Session Report Request

Request for obtaining a session report.

*This model accepts additional fields of type Any.*

## Structure

`SessionReportRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_number` | `str` | Required | Account Number. |
| `imei` | `str` | Required | Device ids. |
| `start_date` | `str` | Optional | Start date of session to include. If not specified  information will be shown from the earliest available (180 days). Can be either date in ISO 8601 format or predefined constants. |
| `end_date` | `str` | Optional | End date of session to include. If not specified  information will be shown to the latest available. Can be either date in ISO 8601 format or predefined constants. |
| `duration_low` | `int` | Optional | The Low value of session duration. |
| `duration_high` | `int` | Optional | The High value of session duration. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "accountNumber": "0844021539-00001",
  "startDate": "2022-12-09T22:01:06.217Z",
  "endDate": "2022-12-09T22:01:08.734Z",
  "imei": "709312034493372",
  "durationLow": null,
  "durationHigh": null,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

