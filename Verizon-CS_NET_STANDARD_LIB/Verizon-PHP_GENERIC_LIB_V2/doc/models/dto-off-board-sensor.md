
# Dto Off Board Sensor

The EUI64 address of the device being removed

## Structure

`DtoOffBoardSensor`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deveui` | `?string` | Optional | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer | getDeveui(): ?string | setDeveui(?string deveui): void |

## Example (as JSON)

```json
{
  "deveui": "The unique EUI64 address of the device"
}
```

