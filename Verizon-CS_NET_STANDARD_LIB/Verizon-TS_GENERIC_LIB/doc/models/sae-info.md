
# Sae Info

## Structure

`SaeInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dataFrames` | [`DataFrame[]`](../../doc/models/data-frame.md) | Required | List of data frames.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `8` |

## Example (as JSON)

```json
{
  "dataFrames": [
    {
      "notUsed": 10,
      "frameType": "unknown",
      "msgId": {
        "furtherInfoID": "`1101000100011010`B",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "startTime": 186,
      "durationTime": 44,
      "priority": 7,
      "notUsed1": 31,
      "regions": [
        {
          "direction": "`1101000100011010`B",
          "description": {
            "path": {
              "offset": {
                "ll": {
                  "nodes": [
                    {
                      "delta": {
                        "nodeLatLon": {
                          "lon": 2,
                          "lat": 52
                        }
                      }
                    },
                    {
                      "delta": {
                        "nodeLatLon": {
                          "lon": 2,
                          "lat": 52
                        }
                      }
                    }
                  ]
                }
              }
            }
          }
        }
      ],
      "notUsed2": 31,
      "notUsed3": 31,
      "content": {
        "advisory": [
          {
            "item": {
              "itis": 10
            },
            "exampleAdditionalProperty": {
              "key1": "val1",
              "key2": "val2"
            }
          },
          {
            "item": {
              "itis": 10
            },
            "exampleAdditionalProperty": {
              "key1": "val1",
              "key2": "val2"
            }
          },
          {
            "item": {
              "itis": 10
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
      },
      "startYear": 12
    }
  ]
}
```

