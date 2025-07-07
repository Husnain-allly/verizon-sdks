
# Dto Device Action Set Response

*This model accepts additional fields of type Object.*

## Structure

`DtoDeviceActionSetResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `actionresult` | [`Array<ActionResultwithDeviceConfig>`](../../doc/models/action-resultwith-device-config.md) | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "actionresult": [
    {
      "createdon": "2016-03-13T12:52:32.123Z",
      "description": "description8",
      "deviceid": "deviceid8",
      "errmsg": "errmsg0",
      "fields": {
        "deviceConfig": {
          "ble": {
            "dataMode": 216,
            "manufacturerId": 180,
            "maxNumScan": 126,
            "minSigStr": 60,
            "monitorPeriod": 88,
            "exampleAdditionalProperty": {
              "key1": "val1",
              "key2": "val2"
            }
          }
        },
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "createdon": "2016-03-13T12:52:32.123Z",
      "description": "description8",
      "deviceid": "deviceid8",
      "errmsg": "errmsg0",
      "fields": {
        "deviceConfig": {
          "ble": {
            "dataMode": 216,
            "manufacturerId": 180,
            "maxNumScan": 126,
            "minSigStr": 60,
            "monitorPeriod": 88,
            "exampleAdditionalProperty": {
              "key1": "val1",
              "key2": "val2"
            }
          }
        },
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

