
# Kpi Info

KPI Info Object

*This model accepts additional fields of type interface{}.*

## Structure

`KpiInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `*string` | Optional | - |
| `Value` | `*string` | Optional | - |
| `NodeName` | `*string` | Optional | - |
| `NodeType` | `*string` | Optional | - |
| `Description` | `*string` | Optional | - |
| `Unit` | `*string` | Optional | - |
| `Category` | `*string` | Optional | - |
| `TimeOfLastUpdate` | `*string` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

