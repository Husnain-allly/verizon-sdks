
# Attribute Setting

Describes an attribute being observed and the frequency with which the attribute is being observed.

*This model accepts additional fields of type array.*

## Structure

`AttributeSetting`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | [`?string(AttributeIdentifier)`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. | getName(): ?string | setName(?string name): void |
| `value` | `?string` | Optional | Attribute value. | getValue(): ?string | setValue(?string value): void |
| `createdOn` | `?DateTime` | Optional | Date and time request was created. | getCreatedOn(): ?\DateTime | setCreatedOn(?\DateTime createdOn): void |
| `isObservable` | `?bool` | Optional | Is the attribute observable? | getIsObservable(): ?bool | setIsObservable(?bool isObservable): void |
| `isObserving` | `?bool` | Optional | Is the attribute being observed? | getIsObserving(): ?bool | setIsObserving(?bool isObserving): void |
| `frequency` | [`?NumericalData`](../../doc/models/numerical-data.md) | Optional | Describes value and unit of time. | getFrequency(): ?NumericalData | setFrequency(?NumericalData frequency): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

