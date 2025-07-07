
# Dto Filter

## Structure

`DtoFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mExpand` | `string \| undefined` | Optional | Use to provide device details for alerts specific to a device |
| `mLimitnumber` | `number \| undefined` | Optional | Limit the number of results returned<br><br>**Constraints**: `>= 0`, `<= 100` |
| `mNopagination` | `boolean \| undefined` | Optional | A flag set to show if pagination requested (false) or not (true) |
| `mPage` | `string \| undefined` | Optional | - |
| `mPagenumber` | `number \| undefined` | Optional | **Constraints**: `>= 0`, `<= 100` |
| `mProjection` | `string[] \| undefined` | Optional | Limits the fields of the device that the user is interested in rather than all of the fields<br><br>**Constraints**: *Maximum Items*: `100` |
| `mSelection` | `Record<string, unknown> \| undefined` | Optional | Filters results based on user defined criteria |

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

