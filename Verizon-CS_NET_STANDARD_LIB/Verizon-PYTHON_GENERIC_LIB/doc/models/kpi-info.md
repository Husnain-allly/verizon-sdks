
# Kpi Info

KPI Info Object

*This model accepts additional fields of type Any.*

## Structure

`KpiInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `str` | Optional | - |
| `value` | `str` | Optional | - |
| `node_name` | `str` | Optional | - |
| `node_type` | `str` | Optional | - |
| `description` | `str` | Optional | - |
| `unit` | `str` | Optional | - |
| `category` | `str` | Optional | - |
| `time_of_last_update` | `str` | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

