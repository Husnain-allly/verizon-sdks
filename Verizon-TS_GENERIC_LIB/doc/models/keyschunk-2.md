
# Keyschunk 2

*This model accepts additional fields of type unknown.*

## Structure

`Keyschunk2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dataPercentage50` | `boolean \| undefined` | Optional | - |
| `dataPercentage75` | `boolean \| undefined` | Optional | - |
| `dataPercentage90` | `boolean \| undefined` | Optional | - |
| `dataPercentage100` | `boolean \| undefined` | Optional | - |
| `smsPercentage50` | `boolean \| undefined` | Optional | - |
| `smsPercentage75` | `boolean \| undefined` | Optional | - |
| `smsPercentage90` | `boolean \| undefined` | Optional | - |
| `smsPercentage100` | `boolean \| undefined` | Optional | - |
| `noOfDaysB4PromoExp` | `number \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "dataPercentage50": false,
  "dataPercentage75": false,
  "dataPercentage90": false,
  "dataPercentage100": false,
  "smsPercentage50": false,
  "smsPercentage75": false,
  "smsPercentage90": false,
  "smsPercentage100": true,
  "NoOfDaysB4PromoExp": 5,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

