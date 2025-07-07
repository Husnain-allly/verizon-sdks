
# Content 3

*This model accepts additional fields of type Any.*

## Structure

`Content3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `speed_limit` | List[[TextPhraseOrITIS](../../doc/models/text-phrase-or-itis.md) \| [TextPhraseOrITIS1](../../doc/models/text-phrase-or-itis-1.md)] | Required | A data frame to allow sequences of ITIS codes, short text strings, and numerical values to be expressed in the normal ITIS vocabulary method and pattern. Note that the allowed text strings are more limited than the normal ITIS format in order to conserve bandwidth.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `16` |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "speedLimit": [
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

