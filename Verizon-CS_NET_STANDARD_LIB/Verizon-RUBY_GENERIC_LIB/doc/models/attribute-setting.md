
# Attribute Setting

Describes an attribute being observed and the frequency with which the attribute is being observed.

*This model accepts additional fields of type Object.*

## Structure

`AttributeSetting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | [`AttributeIdentifier`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. |
| `value` | `String` | Optional | Attribute value. |
| `created_on` | `DateTime` | Optional | Date and time request was created. |
| `is_observable` | `TrueClass \| FalseClass` | Optional | Is the attribute observable? |
| `is_observing` | `TrueClass \| FalseClass` | Optional | Is the attribute being observed? |
| `frequency` | [`NumericalData`](../../doc/models/numerical-data.md) | Optional | Describes value and unit of time. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

