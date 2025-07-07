
# Speed

## Structure

`Speed`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Min` | `double` | Required | The minimum required speed in m/s.<br><br>**Constraints**: `>= 0`, `<= 160` | double getMin() | setMin(double min) |
| `Max` | `double` | Required | The maximum acceptable speed in m/s<br><br>**Constraints**: `>= 0`, `<= 160` | double getMax() | setMax(double max) |

## Example (as JSON)

```json
{
  "min": 23.44,
  "max": 96.86
}
```

