
# Content

*This model accepts additional fields of type Object.*

## Structure

`Content`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `advisory` | Array[[AdvisoryItem](../../doc/models/advisory-item.md) \| [AdvisoryItem1](../../doc/models/advisory-item-1.md)] | Required | The use of ITIS codes interspersed with free text. The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `100` |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
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
}
```

