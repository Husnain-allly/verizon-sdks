
# Dto Sensor Boarding Event

## Structure

`DtoSensorBoardingEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `createdon` | `string \| undefined` | Optional | Timestamp of the record |
| `errmsg` | `string \| undefined` | Optional | Error message |
| `fields` | [`DtoFields \| undefined`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search |
| `state` | `string \| undefined` | Optional | The current status of the device or transaction and will be `success` or `failed` |
| `transactionid` | `string \| undefined` | Optional | The system-generated UUID of the transaction |

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

