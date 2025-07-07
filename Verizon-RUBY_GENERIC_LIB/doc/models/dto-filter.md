
# Dto Filter

## Structure

`DtoFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `m_expand` | `String` | Optional | Use to provide device details for alerts specific to a device |
| `m_limitnumber` | `Integer` | Optional | Limit the number of results returned<br><br>**Constraints**: `>= 0`, `<= 100` |
| `m_nopagination` | `TrueClass \| FalseClass` | Optional | A flag set to show if pagination requested (false) or not (true) |
| `m_page` | `String` | Optional | - |
| `m_pagenumber` | `Integer` | Optional | **Constraints**: `>= 0`, `<= 100` |
| `m_projection` | `Array<String>` | Optional | Limits the fields of the device that the user is interested in rather than all of the fields<br><br>**Constraints**: *Maximum Items*: `100` |
| `m_selection` | `Hash[String, Object]` | Optional | Filters results based on user defined criteria |

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

