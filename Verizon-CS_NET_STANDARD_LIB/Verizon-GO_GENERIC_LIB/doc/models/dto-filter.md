
# Dto Filter

## Structure

`DtoFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MExpand` | `*string` | Optional | Use to provide device details for alerts specific to a device |
| `MLimitnumber` | `*int` | Optional | Limit the number of results returned<br><br>**Constraints**: `>= 0`, `<= 100` |
| `MNopagination` | `*bool` | Optional | A flag set to show if pagination requested (false) or not (true) |
| `MPage` | `*string` | Optional | - |
| `MPagenumber` | `*int` | Optional | **Constraints**: `>= 0`, `<= 100` |
| `MProjection` | `[]string` | Optional | Limits the fields of the device that the user is interested in rather than all of the fields<br><br>**Constraints**: *Maximum Items*: `100` |
| `MSelection` | `map[string]interface{}` | Optional | Filters results based on user defined criteria |

## Example (as JSON)

```json
{
  "$expand": "device detail(s)",
  "$nopagination": true,
  "$page": "The number of pages",
  "$limitnumber": 76,
  "$pagenumber": 12
}
```

