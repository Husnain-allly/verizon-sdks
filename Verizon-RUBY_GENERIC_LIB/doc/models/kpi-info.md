
# Kpi Info

KPI Info Object

*This model accepts additional fields of type Object.*

## Structure

`KpiInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `String` | Optional | - |
| `value` | `String` | Optional | - |
| `node_name` | `String` | Optional | - |
| `node_type` | `String` | Optional | - |
| `description` | `String` | Optional | - |
| `unit` | `String` | Optional | - |
| `category` | `String` | Optional | - |
| `time_of_last_update` | `String` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

