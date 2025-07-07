
# Client Registration Request

Request for /clients/registration endpoint. It requires the Client Type, Subtype and Vendor to be defined.

## Structure

`ClientRegistrationRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `clientType` | [`string(EtxClientType)`](../../doc/models/etx-client-type.md) | Required | The type of the client that is to be registered. This is one of the major traffic participant groups considered in V2X communication. The system uses this value to define which topics the client will be able to publish and subscribe to.<br><br>Values:<br><br>- **Vehicle** - Vehicle with an enclosure around the passengers. (Subtypes: PassengerCar, Truck, Bus, EmergencyVehicle, SchoolBus, MaintenanceVehicle)<br>- **VulnerableRoadUser** - Traffic participants without a protecting enclosure. (Subtypes: Motorcycle, Bicycle, Pedestrian, Scooter)<br>- **TrafficLightController** - A Traffic light controller system. (Subtypes: NA)<br>- **InfrastructureSensor** - Sensors that are deployed in the infrastructure. (Subtypes: RoadSideUnit, Camera, Lidar, Radar, InductiveLoop, MagneticSensor)<br>- **OnboardSensor** - Sensors that are onboard on a vehicle(Subtypes: Camera, Lidar, Radar)<br>- **Software** - A software system or application. (Subtypes: Platform, Application, NA) | getClientType(): string | setClientType(string clientType): void |
| `clientSubtype` | [`string(ClientSubtype)`](../../doc/models/client-subtype.md) | Required | The subtype or subgroup of the client type. This further specifies the client type. For example it will specify if the client is a passenger car or a truck. See the ClientType description for the supported Subtypes for each client type. | getClientSubtype(): string | setClientSubtype(string clientSubtype): void |
| `vendorId` | `string` | Required | The ID the vendor wants its devices to be registered under. E.g. Verizon, GM, Ford, etc.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` | getVendorId(): string | setVendorId(string vendorId): void |
| `deviceId` | `?string` | Optional | The generated ID (UUID v4) for the device. It can be used as:<br><br>- the MQTT Client ID when connecting to the Message Exchange system<br>- a parameter when asking for the connection endpoint<br>- a parameter when finishing the device registration<br>- a parameter when unregistering the device | getDeviceId(): ?string | setDeviceId(?string deviceId): void |
| `imei` | `?string` | Optional | The IMEI number of the device.<br><br>**Constraints**: *Maximum Length*: `19`, *Pattern*: `^(\d{2}-\d{6}-\d{6}-\d{1,2})$\|^(\d{15,16})$` | getImei(): ?string | setImei(?string imei): void |
| `iccid` | `?string` | Optional | The ICCID number of the device.<br><br>**Constraints**: *Minimum Length*: `19`, *Maximum Length*: `20`, *Pattern*: `^(89\d{17,18})$` | getIccid(): ?string | setIccid(?string iccid): void |

## Example (as JSON)

```json
{
  "ClientType": "OnboardSensor",
  "ClientSubtype": "NA",
  "VendorID": "VerizonETX",
  "DeviceID": "a4fcd16a-343d-4527-8203-2f46e3e4ff4b",
  "IMEI": "12-345678-901234-5",
  "ICCID": "89345678901234567890"
}
```

