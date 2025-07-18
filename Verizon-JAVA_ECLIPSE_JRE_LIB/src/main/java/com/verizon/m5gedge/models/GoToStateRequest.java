/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonAnySetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.util.List;
import java.util.Map;

/**
 * This is a model class for GoToStateRequest type.
 */
public class GoToStateRequest {
    private String serviceName;
    private String stateName;
    private String servicePlan;
    private String mdnZipCode;
    private List<AccountDeviceList> devices;
    private DeviceFilter filter;
    private String carrierIpPoolName;
    private String publicIpRestriction;
    private String skuNumber;
    private List<CustomFields> customFields;
    private List<Object> devicesWithServiceAddress;
    private String ipaddress;
    private String groupName;
    private PlaceOfUse primaryPlaceOfUse;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public GoToStateRequest() {
    }

    /**
     * Initialization constructor.
     * @param  serviceName  String value for serviceName.
     * @param  stateName  String value for stateName.
     * @param  servicePlan  String value for servicePlan.
     * @param  mdnZipCode  String value for mdnZipCode.
     * @param  devices  List of AccountDeviceList value for devices.
     * @param  filter  DeviceFilter value for filter.
     * @param  carrierIpPoolName  String value for carrierIpPoolName.
     * @param  publicIpRestriction  String value for publicIpRestriction.
     * @param  skuNumber  String value for skuNumber.
     * @param  customFields  List of CustomFields value for customFields.
     * @param  devicesWithServiceAddress  List of Object value for devicesWithServiceAddress.
     * @param  ipaddress  String value for ipaddress.
     * @param  groupName  String value for groupName.
     * @param  primaryPlaceOfUse  PlaceOfUse value for primaryPlaceOfUse.
     */
    public GoToStateRequest(
            String serviceName,
            String stateName,
            String servicePlan,
            String mdnZipCode,
            List<AccountDeviceList> devices,
            DeviceFilter filter,
            String carrierIpPoolName,
            String publicIpRestriction,
            String skuNumber,
            List<CustomFields> customFields,
            List<Object> devicesWithServiceAddress,
            String ipaddress,
            String groupName,
            PlaceOfUse primaryPlaceOfUse) {
        this.serviceName = serviceName;
        this.stateName = stateName;
        this.servicePlan = servicePlan;
        this.mdnZipCode = mdnZipCode;
        this.devices = devices;
        this.filter = filter;
        this.carrierIpPoolName = carrierIpPoolName;
        this.publicIpRestriction = publicIpRestriction;
        this.skuNumber = skuNumber;
        this.customFields = customFields;
        this.devicesWithServiceAddress = devicesWithServiceAddress;
        this.ipaddress = ipaddress;
        this.groupName = groupName;
        this.primaryPlaceOfUse = primaryPlaceOfUse;
    }

    /**
     * Getter for ServiceName.
     * The name of a customer-defined service to push the devices to.
     * @return Returns the String
     */
    @JsonGetter("serviceName")
    public String getServiceName() {
        return serviceName;
    }

    /**
     * Setter for ServiceName.
     * The name of a customer-defined service to push the devices to.
     * @param serviceName Value for String
     */
    @JsonSetter("serviceName")
    public void setServiceName(String serviceName) {
        this.serviceName = serviceName;
    }

    /**
     * Getter for StateName.
     * The name of a customer-defined stage state to push the devices to.
     * @return Returns the String
     */
    @JsonGetter("stateName")
    public String getStateName() {
        return stateName;
    }

    /**
     * Setter for StateName.
     * The name of a customer-defined stage state to push the devices to.
     * @param stateName Value for String
     */
    @JsonSetter("stateName")
    public void setStateName(String stateName) {
        this.stateName = stateName;
    }

    /**
     * Getter for ServicePlan.
     * The service plan code that you want to assign to all specified devices in the new state.
     * @return Returns the String
     */
    @JsonGetter("servicePlan")
    public String getServicePlan() {
        return servicePlan;
    }

    /**
     * Setter for ServicePlan.
     * The service plan code that you want to assign to all specified devices in the new state.
     * @param servicePlan Value for String
     */
    @JsonSetter("servicePlan")
    public void setServicePlan(String servicePlan) {
        this.servicePlan = servicePlan;
    }

    /**
     * Getter for MdnZipCode.
     * The Zip code of the location where the line of service will primarily be used, or a Zip code
     * that you have been told to use with these devices. For accounts that are configured for
     * geographic numbering, this is the ZIP code from which the MDN will be derived.
     * @return Returns the String
     */
    @JsonGetter("mdnZipCode")
    public String getMdnZipCode() {
        return mdnZipCode;
    }

    /**
     * Setter for MdnZipCode.
     * The Zip code of the location where the line of service will primarily be used, or a Zip code
     * that you have been told to use with these devices. For accounts that are configured for
     * geographic numbering, this is the ZIP code from which the MDN will be derived.
     * @param mdnZipCode Value for String
     */
    @JsonSetter("mdnZipCode")
    public void setMdnZipCode(String mdnZipCode) {
        this.mdnZipCode = mdnZipCode;
    }

    /**
     * Getter for Devices.
     * Up to 10,000 devices that you want to push to a different state, specified by device
     * identifier.
     * @return Returns the List of AccountDeviceList
     */
    @JsonGetter("devices")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<AccountDeviceList> getDevices() {
        return devices;
    }

    /**
     * Setter for Devices.
     * Up to 10,000 devices that you want to push to a different state, specified by device
     * identifier.
     * @param devices Value for List of AccountDeviceList
     */
    @JsonSetter("devices")
    public void setDevices(List<AccountDeviceList> devices) {
        this.devices = devices;
    }

    /**
     * Getter for Filter.
     * Specify the kind of the device identifier, the type of match, and the string that you want to
     * match.
     * @return Returns the DeviceFilter
     */
    @JsonGetter("filter")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public DeviceFilter getFilter() {
        return filter;
    }

    /**
     * Setter for Filter.
     * Specify the kind of the device identifier, the type of match, and the string that you want to
     * match.
     * @param filter Value for DeviceFilter
     */
    @JsonSetter("filter")
    public void setFilter(DeviceFilter filter) {
        this.filter = filter;
    }

    /**
     * Getter for CarrierIpPoolName.
     * The pool from which your device IP addresses will be derived if the service or state change
     * requires new IP addresses.If you do not include this element, the default pool will be used.
     * @return Returns the String
     */
    @JsonGetter("carrierIpPoolName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getCarrierIpPoolName() {
        return carrierIpPoolName;
    }

    /**
     * Setter for CarrierIpPoolName.
     * The pool from which your device IP addresses will be derived if the service or state change
     * requires new IP addresses.If you do not include this element, the default pool will be used.
     * @param carrierIpPoolName Value for String
     */
    @JsonSetter("carrierIpPoolName")
    public void setCarrierIpPoolName(String carrierIpPoolName) {
        this.carrierIpPoolName = carrierIpPoolName;
    }

    /**
     * Getter for PublicIpRestriction.
     * For devices with static IP addresses on the public network, this specifies whether the
     * devices have general access to the Internet. Valid values are “restricted” or “unrestricted”.
     * @return Returns the String
     */
    @JsonGetter("publicIpRestriction")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getPublicIpRestriction() {
        return publicIpRestriction;
    }

    /**
     * Setter for PublicIpRestriction.
     * For devices with static IP addresses on the public network, this specifies whether the
     * devices have general access to the Internet. Valid values are “restricted” or “unrestricted”.
     * @param publicIpRestriction Value for String
     */
    @JsonSetter("publicIpRestriction")
    public void setPublicIpRestriction(String publicIpRestriction) {
        this.publicIpRestriction = publicIpRestriction;
    }

    /**
     * Getter for SkuNumber.
     * The Stock Keeping Unit (SKU) number of a 4G device type with an embedded SIM. Can be used
     * with ICCID or EID device identifiers in lieu of an IMEI when activating 4G devices. The
     * SkuNumber will be used with all devices in the request, so all devices must be of the same
     * type.
     * @return Returns the String
     */
    @JsonGetter("skuNumber")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getSkuNumber() {
        return skuNumber;
    }

    /**
     * Setter for SkuNumber.
     * The Stock Keeping Unit (SKU) number of a 4G device type with an embedded SIM. Can be used
     * with ICCID or EID device identifiers in lieu of an IMEI when activating 4G devices. The
     * SkuNumber will be used with all devices in the request, so all devices must be of the same
     * type.
     * @param skuNumber Value for String
     */
    @JsonSetter("skuNumber")
    public void setSkuNumber(String skuNumber) {
        this.skuNumber = skuNumber;
    }

    /**
     * Getter for CustomFields.
     * The names and values of any custom fields that you want to set for the devices.
     * @return Returns the List of CustomFields
     */
    @JsonGetter("customFields")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<CustomFields> getCustomFields() {
        return customFields;
    }

    /**
     * Setter for CustomFields.
     * The names and values of any custom fields that you want to set for the devices.
     * @param customFields Value for List of CustomFields
     */
    @JsonSetter("customFields")
    public void setCustomFields(List<CustomFields> customFields) {
        this.customFields = customFields;
    }

    /**
     * Getter for DevicesWithServiceAddress.
     * This is an array that associates an IP address with a device identifier. This variable is
     * only relevant for Business Internet/Fixed Wireless Access
     * @return Returns the List of Object
     */
    @JsonGetter("devicesWithServiceAddress")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<Object> getDevicesWithServiceAddress() {
        return devicesWithServiceAddress;
    }

    /**
     * Setter for DevicesWithServiceAddress.
     * This is an array that associates an IP address with a device identifier. This variable is
     * only relevant for Business Internet/Fixed Wireless Access
     * @param devicesWithServiceAddress Value for List of Object
     */
    @JsonSetter("devicesWithServiceAddress")
    public void setDevicesWithServiceAddress(List<Object> devicesWithServiceAddress) {
        this.devicesWithServiceAddress = devicesWithServiceAddress;
    }

    /**
     * Getter for Ipaddress.
     * The IP address of the device.
     * @return Returns the String
     */
    @JsonGetter("ipAddress")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getIpaddress() {
        return ipaddress;
    }

    /**
     * Setter for Ipaddress.
     * The IP address of the device.
     * @param ipaddress Value for String
     */
    @JsonSetter("ipAddress")
    public void setIpaddress(String ipaddress) {
        this.ipaddress = ipaddress;
    }

    /**
     * Getter for GroupName.
     * The name of a device group that the devices should be added to.
     * @return Returns the String
     */
    @JsonGetter("groupName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getGroupName() {
        return groupName;
    }

    /**
     * Setter for GroupName.
     * The name of a device group that the devices should be added to.
     * @param groupName Value for String
     */
    @JsonSetter("groupName")
    public void setGroupName(String groupName) {
        this.groupName = groupName;
    }

    /**
     * Getter for PrimaryPlaceOfUse.
     * The customer name and the address of the device's primary place of use. Leave these fields
     * empty to use the account profile address as the primary place of use. These values will be
     * applied to all devices in the request.If the account is enabled for non-geographic MDNs and
     * the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for
     * the device.
     * @return Returns the PlaceOfUse
     */
    @JsonGetter("primaryPlaceOfUse")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public PlaceOfUse getPrimaryPlaceOfUse() {
        return primaryPlaceOfUse;
    }

    /**
     * Setter for PrimaryPlaceOfUse.
     * The customer name and the address of the device's primary place of use. Leave these fields
     * empty to use the account profile address as the primary place of use. These values will be
     * applied to all devices in the request.If the account is enabled for non-geographic MDNs and
     * the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for
     * the device.
     * @param primaryPlaceOfUse Value for PlaceOfUse
     */
    @JsonSetter("primaryPlaceOfUse")
    public void setPrimaryPlaceOfUse(PlaceOfUse primaryPlaceOfUse) {
        this.primaryPlaceOfUse = primaryPlaceOfUse;
    }

    /**
     * Hidden method for the serialization of additional properties.
     * @return The map of additionally set properties.
     */
    @JsonAnyGetter
    private Map<String, Object> getAdditionalProperties() {
        return additionalProperties.getAdditionalProperties();
    }

    /**
     * Hidden method for the de-serialization of additional properties.
     * @param name The name of the additional property.
     * @param value The Object value of the additional property.
     */
    @JsonAnySetter
    private void setAdditionalProperties(String name, Object value) {
        additionalProperties.setAdditionalProperty(name,
                ConversionHelper.convertToSimpleType(value,
                        x -> x),
                true);
    }

    /**
     * Getter for the value of additional properties based on provided property name.
     * @param name The name of the additional property.
     * @return Either the Object property value or null if not exist.
     */
    
    public Object getAdditionalProperty(String name) {
        return additionalProperties.getAdditionalProperty(name);
    }

    /**
     * Converts this GoToStateRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "GoToStateRequest [" + "serviceName=" + serviceName + ", stateName=" + stateName
                + ", servicePlan=" + servicePlan + ", mdnZipCode=" + mdnZipCode + ", devices="
                + devices + ", filter=" + filter + ", carrierIpPoolName=" + carrierIpPoolName
                + ", publicIpRestriction=" + publicIpRestriction + ", skuNumber=" + skuNumber
                + ", customFields=" + customFields + ", devicesWithServiceAddress="
                + devicesWithServiceAddress + ", ipaddress=" + ipaddress + ", groupName="
                + groupName + ", primaryPlaceOfUse=" + primaryPlaceOfUse + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link GoToStateRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link GoToStateRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(serviceName, stateName, servicePlan, mdnZipCode)
                .devices(getDevices())
                .filter(getFilter())
                .carrierIpPoolName(getCarrierIpPoolName())
                .publicIpRestriction(getPublicIpRestriction())
                .skuNumber(getSkuNumber())
                .customFields(getCustomFields())
                .devicesWithServiceAddress(getDevicesWithServiceAddress())
                .ipaddress(getIpaddress())
                .groupName(getGroupName())
                .primaryPlaceOfUse(getPrimaryPlaceOfUse());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link GoToStateRequest}.
     */
    public static class Builder {
        private String serviceName;
        private String stateName;
        private String servicePlan;
        private String mdnZipCode;
        private List<AccountDeviceList> devices;
        private DeviceFilter filter;
        private String carrierIpPoolName;
        private String publicIpRestriction;
        private String skuNumber;
        private List<CustomFields> customFields;
        private List<Object> devicesWithServiceAddress;
        private String ipaddress;
        private String groupName;
        private PlaceOfUse primaryPlaceOfUse;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  serviceName  String value for serviceName.
         * @param  stateName  String value for stateName.
         * @param  servicePlan  String value for servicePlan.
         * @param  mdnZipCode  String value for mdnZipCode.
         */
        public Builder(String serviceName, String stateName, String servicePlan,
                String mdnZipCode) {
            this.serviceName = serviceName;
            this.stateName = stateName;
            this.servicePlan = servicePlan;
            this.mdnZipCode = mdnZipCode;
        }

        /**
         * Setter for serviceName.
         * @param  serviceName  String value for serviceName.
         * @return Builder
         */
        public Builder serviceName(String serviceName) {
            this.serviceName = serviceName;
            return this;
        }

        /**
         * Setter for stateName.
         * @param  stateName  String value for stateName.
         * @return Builder
         */
        public Builder stateName(String stateName) {
            this.stateName = stateName;
            return this;
        }

        /**
         * Setter for servicePlan.
         * @param  servicePlan  String value for servicePlan.
         * @return Builder
         */
        public Builder servicePlan(String servicePlan) {
            this.servicePlan = servicePlan;
            return this;
        }

        /**
         * Setter for mdnZipCode.
         * @param  mdnZipCode  String value for mdnZipCode.
         * @return Builder
         */
        public Builder mdnZipCode(String mdnZipCode) {
            this.mdnZipCode = mdnZipCode;
            return this;
        }

        /**
         * Setter for devices.
         * @param  devices  List of AccountDeviceList value for devices.
         * @return Builder
         */
        public Builder devices(List<AccountDeviceList> devices) {
            this.devices = devices;
            return this;
        }

        /**
         * Setter for filter.
         * @param  filter  DeviceFilter value for filter.
         * @return Builder
         */
        public Builder filter(DeviceFilter filter) {
            this.filter = filter;
            return this;
        }

        /**
         * Setter for carrierIpPoolName.
         * @param  carrierIpPoolName  String value for carrierIpPoolName.
         * @return Builder
         */
        public Builder carrierIpPoolName(String carrierIpPoolName) {
            this.carrierIpPoolName = carrierIpPoolName;
            return this;
        }

        /**
         * Setter for publicIpRestriction.
         * @param  publicIpRestriction  String value for publicIpRestriction.
         * @return Builder
         */
        public Builder publicIpRestriction(String publicIpRestriction) {
            this.publicIpRestriction = publicIpRestriction;
            return this;
        }

        /**
         * Setter for skuNumber.
         * @param  skuNumber  String value for skuNumber.
         * @return Builder
         */
        public Builder skuNumber(String skuNumber) {
            this.skuNumber = skuNumber;
            return this;
        }

        /**
         * Setter for customFields.
         * @param  customFields  List of CustomFields value for customFields.
         * @return Builder
         */
        public Builder customFields(List<CustomFields> customFields) {
            this.customFields = customFields;
            return this;
        }

        /**
         * Setter for devicesWithServiceAddress.
         * @param  devicesWithServiceAddress  List of Object value for devicesWithServiceAddress.
         * @return Builder
         */
        public Builder devicesWithServiceAddress(List<Object> devicesWithServiceAddress) {
            this.devicesWithServiceAddress = devicesWithServiceAddress;
            return this;
        }

        /**
         * Setter for ipaddress.
         * @param  ipaddress  String value for ipaddress.
         * @return Builder
         */
        public Builder ipaddress(String ipaddress) {
            this.ipaddress = ipaddress;
            return this;
        }

        /**
         * Setter for groupName.
         * @param  groupName  String value for groupName.
         * @return Builder
         */
        public Builder groupName(String groupName) {
            this.groupName = groupName;
            return this;
        }

        /**
         * Setter for primaryPlaceOfUse.
         * @param  primaryPlaceOfUse  PlaceOfUse value for primaryPlaceOfUse.
         * @return Builder
         */
        public Builder primaryPlaceOfUse(PlaceOfUse primaryPlaceOfUse) {
            this.primaryPlaceOfUse = primaryPlaceOfUse;
            return this;
        }

        /**
         * Setter for additional property that are not in model fields.
         * @param name The name of the additional property.
         * @param value The Object value of the additional property.
         * @return Builder.
         */
        public Builder additionalProperty(String name, Object value) {
            this.additionalProperties.setAdditionalProperty(name, value);
            return this;
        }

        /**
         * Builds a new {@link GoToStateRequest} object using the set fields.
         * @return {@link GoToStateRequest}
         */
        public GoToStateRequest build() {
            GoToStateRequest model =
                    new GoToStateRequest(serviceName, stateName, servicePlan, mdnZipCode, devices,
                            filter, carrierIpPoolName, publicIpRestriction, skuNumber, customFields,
                            devicesWithServiceAddress, ipaddress, groupName, primaryPlaceOfUse);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
