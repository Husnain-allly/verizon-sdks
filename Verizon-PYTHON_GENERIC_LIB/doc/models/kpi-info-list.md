
# Kpi Info List

*This model accepts additional fields of type Any.*

## Structure

`KpiInfoList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `kpi_info_list` | [`List[KpiInfo]`](../../doc/models/kpi-info.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "KpiInfoList": [
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

