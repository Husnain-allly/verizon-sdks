
# Associate Label Request

*This model accepts additional fields of type Object.*

## Structure

`AssociateLabelRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Required | The name of a billing account. An account name is usually numeric, and must include any leading zeros. |
| `labels` | [`AccountLabels`](../../doc/models/account-labels.md) | Required | Maximum of 2,000 objects are allowed in the array. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "labels": {
    "devices": [
      {
        "deviceIds": [
          {
            "id": "id0",
            "kind": "kind8",
            "exampleAdditionalProperty": {
              "key1": "val1",
              "key2": "val2"
            }
          }
        ]
      }
    ],
    "label": [
      {
        "name": "name0",
        "value": "value2",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "name": "name0",
        "value": "value2",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "name": "name0",
        "value": "value2",
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

