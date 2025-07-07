
# Dto Off Board Sensor

The EUI64 address of the device being removed

## Structure

`DtoOffBoardSensor`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Deveui` | `String` | Optional | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer | String getDeveui() | setDeveui(String deveui) |

## Example (as JSON)

```json
{
  "deveui": "The unique EUI64 address of the device"
}
```

