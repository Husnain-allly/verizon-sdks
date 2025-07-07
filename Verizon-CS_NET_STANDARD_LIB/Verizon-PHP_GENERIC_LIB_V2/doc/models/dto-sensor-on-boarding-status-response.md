
# Dto Sensor on Boarding Status Response

## Structure

`DtoSensorOnBoardingStatusResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `events` | [`?(DtoSensorBoardingEvent[])`](../../doc/models/dto-sensor-boarding-event.md) | Optional | **Constraints**: *Maximum Items*: `100` | getEvents(): ?array | setEvents(?array events): void |

## Example (as JSON)

```json
{
  "events": [
    {
      "createdon": "2016-03-13T12:52:32.123Z",
      "errmsg": "errmsg2",
      "fields": null,
      "state": "state6",
      "transactionid": "transactionid8"
    },
    {
      "createdon": "2016-03-13T12:52:32.123Z",
      "errmsg": "errmsg2",
      "fields": null,
      "state": "state6",
      "transactionid": "transactionid8"
    }
  ]
}
```

