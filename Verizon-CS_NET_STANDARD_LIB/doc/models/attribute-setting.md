
# Attribute Setting

Describes an attribute being observed and the frequency with which the attribute is being observed.

*This model accepts additional fields of type object.*

## Structure

`AttributeSetting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | [`AttributeIdentifier?`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. |
| `MValue` | `string` | Optional | Attribute value. |
| `CreatedOn` | `DateTime?` | Optional | Date and time request was created. |
| `IsObservable` | `bool?` | Optional | Is the attribute observable? |
| `IsObserving` | `bool?` | Optional | Is the attribute being observed? |
| `Frequency` | [`NumericalData`](../../doc/models/numerical-data.md) | Optional | Describes value and unit of time. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "MANUFACTURER",
  "value": "string",
  "createdOn": "2019-09-07T23:08:03.532Z",
  "isObservable": true,
  "isObserving": true,
  "frequency": {
    "value": 5,
    "unit": "SECOND"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

