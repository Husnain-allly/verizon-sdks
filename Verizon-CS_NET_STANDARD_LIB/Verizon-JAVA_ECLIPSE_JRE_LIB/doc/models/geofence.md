
# Geofence

## Structure

`Geofence`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Type` | `String` | Required | **Constraints**: *Maximum Length*: `20`, *Pattern*: `^[a-zA-Z0-9]*$` | String getType() | setType(String type) |
| `Coordinates` | `List<List<Double>>` | Required | **Constraints**: *Minimum Items*: `4`, *Maximum Items*: `20`, `>= -180`, `<= 180` | List<List<Double>> getCoordinates() | setCoordinates(List<List<Double>> coordinates) |

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

