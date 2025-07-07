
# Speed

## Structure

`Speed`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `min` | `float` | Required | The minimum required speed in m/s.<br><br>**Constraints**: `>= 0`, `<= 160` | getMin(): float | setMin(float min): void |
| `max` | `float` | Required | The maximum acceptable speed in m/s<br><br>**Constraints**: `>= 0`, `<= 160` | getMax(): float | setMax(float max): void |

## Example (as JSON)

```json
{
  "min": 23.44,
  "max": 96.86
}
```

