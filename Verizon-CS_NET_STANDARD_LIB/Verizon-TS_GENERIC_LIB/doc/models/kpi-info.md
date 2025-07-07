
# Kpi Info

KPI Info Object

*This model accepts additional fields of type unknown.*

## Structure

`KpiInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string \| undefined` | Optional | - |
| `value` | `string \| undefined` | Optional | - |
| `nodeName` | `string \| undefined` | Optional | - |
| `nodeType` | `string \| undefined` | Optional | - |
| `description` | `string \| undefined` | Optional | - |
| `unit` | `string \| undefined` | Optional | - |
| `category` | `string \| undefined` | Optional | - |
| `timeOfLastUpdate` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "name": "DOWNLINK_THROUGHPUT",
  "value": "23.2",
  "nodeName": "132924_ENB_VZ_EULESS_OLTE_RD-01",
  "nodeType": "BASEBAND",
  "description": "Downlink throughput (4G)",
  "unit": "Mbps",
  "category": "Network Performance Radio",
  "timeOfLastUpdate": "2022-12-07T08:39:59.228Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

