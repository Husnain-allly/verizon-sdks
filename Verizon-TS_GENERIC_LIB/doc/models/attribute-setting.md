
# Attribute Setting

Describes an attribute being observed and the frequency with which the attribute is being observed.

*This model accepts additional fields of type unknown.*

## Structure

`AttributeSetting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | [`AttributeIdentifier \| undefined`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. |
| `value` | `string \| undefined` | Optional | Attribute value. |
| `createdOn` | `string \| undefined` | Optional | Date and time request was created. |
| `isObservable` | `boolean \| undefined` | Optional | Is the attribute observable? |
| `isObserving` | `boolean \| undefined` | Optional | Is the attribute being observed? |
| `frequency` | [`NumericalData \| undefined`](../../doc/models/numerical-data.md) | Optional | Describes value and unit of time. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

