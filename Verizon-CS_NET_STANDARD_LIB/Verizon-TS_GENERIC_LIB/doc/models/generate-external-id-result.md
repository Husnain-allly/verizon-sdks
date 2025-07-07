
# Generate External Id Result

A new external ID.

*This model accepts additional fields of type unknown.*

## Structure

`GenerateExternalIdResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `externalid` | `string \| undefined` | Optional | Newly created security string. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "externalid": "ZlJnih8BfqsosZrEEkfPuR3aGOk2i-HIr6tXN275ioJF6bezIrQB9EbzpTRep8J7RmV7QH==",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

