/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonAnySetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.util.List;
import java.util.Map;

/**
 * This is a model class for V3LicenseImei type.
 */
public class V3LicenseImei {
    private List<String> deviceList;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public V3LicenseImei() {
    }

    /**
     * Initialization constructor.
     * @param  deviceList  List of String value for deviceList.
     */
    public V3LicenseImei(
            List<String> deviceList) {
        this.deviceList = deviceList;
    }

    /**
     * Getter for DeviceList.
     * Device IMEI list.
     * @return Returns the List of String
     */
    @JsonGetter("deviceList")
    public List<String> getDeviceList() {
        return deviceList;
    }

    /**
     * Setter for DeviceList.
     * Device IMEI list.
     * @param deviceList Value for List of String
     */
    @JsonSetter("deviceList")
    public void setDeviceList(List<String> deviceList) {
        this.deviceList = deviceList;
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
     * Converts this V3LicenseImei into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "V3LicenseImei [" + "deviceList=" + deviceList + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link V3LicenseImei.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link V3LicenseImei.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(deviceList);
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link V3LicenseImei}.
     */
    public static class Builder {
        private List<String> deviceList;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  deviceList  List of String value for deviceList.
         */
        public Builder(List<String> deviceList) {
            this.deviceList = deviceList;
        }

        /**
         * Setter for deviceList.
         * @param  deviceList  List of String value for deviceList.
         * @return Builder
         */
        public Builder deviceList(List<String> deviceList) {
            this.deviceList = deviceList;
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
         * Builds a new {@link V3LicenseImei} object using the set fields.
         * @return {@link V3LicenseImei}
         */
        public V3LicenseImei build() {
            V3LicenseImei model =
                    new V3LicenseImei(deviceList);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
