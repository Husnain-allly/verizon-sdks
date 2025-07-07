
# Location

Device location information.

*This model accepts additional fields of type array.*

## Structure

`Location`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `msid` | `?string` | Optional | MDN. | getMsid(): ?string | setMsid(?string msid): void |
| `pd` | [`?PositionData`](../../doc/models/position-data.md) | Optional | Position data. | getPd(): ?PositionData | setPd(?PositionData pd): void |
| `error` | [`?PositionError`](../../doc/models/position-error.md) | Optional | Position error. | getError(): ?PositionError | setError(?PositionError error): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "msid": "7892345678",
  "pd": {
    "time": "20170520004421",
    "x": "33.45324",
    "y": "-84.59621",
    "radius": "5571",
    "qos": false,
    "utcoffset": "utcoffset2",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "error": {
    "time": "time4",
    "utcoffset": "utcoffset4",
    "type": "type6",
    "info": "info4",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

