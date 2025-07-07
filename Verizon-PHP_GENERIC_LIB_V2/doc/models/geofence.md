
# Geofence

## Structure

`Geofence`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `type` | `string` | Required | **Constraints**: *Maximum Length*: `20`, *Pattern*: `^[a-zA-Z0-9]*$` | getType(): string | setType(string type): void |
| `coordinates` | `float[][]` | Required | **Constraints**: *Minimum Items*: `4`, *Maximum Items*: `20`, `>= -180`, `<= 180` | getCoordinates(): array | setCoordinates(array coordinates): void |

## Example (as JSON)

```json
{
  "type": "Polygon",
  "coordinates": [
    [
      -77.479395,
      38.990773
    ],
    [
      -77.114566,
      38.99944
    ],
    [
      -77.100228,
      38.817204
    ],
    [
      -77.418059,
      38.827754
    ],
    [
      -77.479395,
      38.990773
    ]
  ]
}
```

