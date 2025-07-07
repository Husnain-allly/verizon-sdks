
# Dto Sensor Boarding Event

## Structure

`DtoSensorBoardingEvent`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Createdon` | `LocalDateTime` | Optional | Timestamp of the record | LocalDateTime getCreatedon() | setCreatedon(LocalDateTime createdon) |
| `Errmsg` | `String` | Optional | Error message | String getErrmsg() | setErrmsg(String errmsg) |
| `Fields` | [`DtoFields`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search | DtoFields getFields() | setFields(DtoFields fields) |
| `State` | `String` | Optional | The current status of the device or transaction and will be `success` or `failed` | String getState() | setState(String state) |
| `Transactionid` | `String` | Optional | The system-generated UUID of the transaction | String getTransactionid() | setTransactionid(String transactionid) |

## Example (as JSON)

```json
{
  "createdon": "10/02/2023 15:46:34",
  "errmsg": "provider_service_error",
  "fields": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "state": "success",
  "transactionid": "afbcc00d-eeee-ffff-gggg-38b4333fcf06"
}
```

