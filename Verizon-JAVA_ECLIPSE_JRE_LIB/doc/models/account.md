
# Account

Returns information about a specified account.

*This model accepts additional fields of type Object.*

## Structure

`Account`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | The name of the account. | String getAccountName() | setAccountName(String accountName) |
| `AccountNumber` | `String` | Optional | The billing number of the account. | String getAccountNumber() | setAccountNumber(String accountNumber) |
| `OrganizationName` | `String` | Optional | The name of the organization that the account is part of. | String getOrganizationName() | setOrganizationName(String organizationName) |
| `IsProvisioningAllowed` | `Boolean` | Optional | True if devices can be added to the account and activated with a single request. False if devices must be added to the account before they can be activated. | Boolean getIsProvisioningAllowed() | setIsProvisioningAllowed(Boolean isProvisioningAllowed) |
| `Carriers` | `List<String>` | Optional | The names of all carriers for the account. | List<String> getCarriers() | setCarriers(List<String> carriers) |
| `Features` | `List<String>` | Optional | The names of features that are enabled for the account. | List<String> getFeatures() | setFeatures(List<String> features) |
| `IpPools` | [`List<IpPool>`](../../doc/models/ip-pool.md) | Optional | Array of IP pools that are available to the account. | List<IpPool> getIpPools() | setIpPools(List<IpPool> ipPools) |
| `ServicePlans` | [`List<ServicePlan>`](../../doc/models/service-plan.md) | Optional | Array of service plans that are available to the account. | List<ServicePlan> getServicePlans() | setServicePlans(List<ServicePlan> servicePlans) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "Chintan_CPNStaticBulk",
  "accountNumber": "1234567890-77777",
  "organizationName": "ChintanCPNBulk",
  "isProvisioningAllowed": true,
  "carriers": [
    "Verizon Wireless"
  ],
  "features": [
    "Static IP",
    "Dynamic IP",
    "Customer PN"
  ],
  "iPPools": [
    {
      "poolName": "ACMESTATIC001",
      "poolType": "Static IP",
      "isDefaultPool": true
    },
    {
      "poolName": "ACMEDYNAMIC001",
      "poolType": "Dynamic IP",
      "isDefaultPool": false
    }
  ],
  "servicePlans": [
    {
      "name": "",
      "code": "92876",
      "sizeKb": 1,
      "carrierServicePlanCode": "",
      "extendedAttributes": []
    },
    {
      "name": "",
      "code": "92876",
      "sizeKb": 1,
      "carrierServicePlanCode": "",
      "extendedAttributes": []
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

