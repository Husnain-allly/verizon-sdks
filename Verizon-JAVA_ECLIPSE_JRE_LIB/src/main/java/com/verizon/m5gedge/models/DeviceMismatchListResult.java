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
 * This is a model class for DeviceMismatchListResult type.
 */
public class DeviceMismatchListResult {
    private List<MismatchedDevice> devices;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public DeviceMismatchListResult() {
    }

    /**
     * Initialization constructor.
     * @param  devices  List of MismatchedDevice value for devices.
     */
    public DeviceMismatchListResult(
            List<MismatchedDevice> devices) {
        this.devices = devices;
    }

    /**
     * Getter for Devices.
     * A list of specific devices that you want to check, specified by ICCID or MDN.
     * @return Returns the List of MismatchedDevice
     */
    @JsonGetter("devices")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<MismatchedDevice> getDevices() {
        return devices;
    }

    /**
     * Setter for Devices.
     * A list of specific devices that you want to check, specified by ICCID or MDN.
     * @param devices Value for List of MismatchedDevice
     */
    @JsonSetter("devices")
    public void setDevices(List<MismatchedDevice> devices) {
        this.devices = devices;
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
     * Converts this DeviceMismatchListResult into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DeviceMismatchListResult [" + "devices=" + devices + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link DeviceMismatchListResult.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DeviceMismatchListResult.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .devices(getDevices());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link DeviceMismatchListResult}.
     */
    public static class Builder {
        private List<MismatchedDevice> devices;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for devices.
         * @param  devices  List of MismatchedDevice value for devices.
         * @return Builder
         */
        public Builder devices(List<MismatchedDevice> devices) {
            this.devices = devices;
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
         * Builds a new {@link DeviceMismatchListResult} object using the set fields.
         * @return {@link DeviceMismatchListResult}
         */
        public DeviceMismatchListResult build() {
            DeviceMismatchListResult model =
                    new DeviceMismatchListResult(devices);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
