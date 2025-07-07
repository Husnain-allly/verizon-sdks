
# Dto Sensor Boarding Event

## Structure

`DtoSensorBoardingEvent`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `createdon` | `?DateTime` | Optional | Timestamp of the record | getCreatedon(): ?\DateTime | setCreatedon(?\DateTime createdon): void |
| `errmsg` | `?string` | Optional | Error message | getErrmsg(): ?string | setErrmsg(?string errmsg): void |
| `fields` | [`?DtoFields`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search | getFields(): ?DtoFields | setFields(?DtoFields fields): void |
| `state` | `?string` | Optional | The current status of the device or transaction and will be `success` or `failed` | getState(): ?string | setState(?string state): void |
| `transactionid` | `?string` | Optional | The system-generated UUID of the transaction | getTransactionid(): ?string | setTransactionid(?string transactionid): void |

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

