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
 * This is a model class for AccountLabels type.
 */
public class AccountLabels {
    private List<DeviceList> devices;
    private List<DeviceLabels> label;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public AccountLabels() {
    }

    /**
     * Initialization constructor.
     * @param  devices  List of DeviceList value for devices.
     * @param  label  List of DeviceLabels value for label.
     */
    public AccountLabels(
            List<DeviceList> devices,
            List<DeviceLabels> label) {
        this.devices = devices;
        this.label = label;
    }

    /**
     * Getter for Devices.
     * @return Returns the List of DeviceList
     */
    @JsonGetter("devices")
    public List<DeviceList> getDevices() {
        return devices;
    }

    /**
     * Setter for Devices.
     * @param devices Value for List of DeviceList
     */
    @JsonSetter("devices")
    public void setDevices(List<DeviceList> devices) {
        this.devices = devices;
    }

    /**
     * Getter for Label.
     * @return Returns the List of DeviceLabels
     */
    @JsonGetter("label")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<DeviceLabels> getLabel() {
        return label;
    }

    /**
     * Setter for Label.
     * @param label Value for List of DeviceLabels
     */
    @JsonSetter("label")
    public void setLabel(List<DeviceLabels> label) {
        this.label = label;
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
     * Converts this AccountLabels into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "AccountLabels [" + "devices=" + devices + ", label=" + label
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link AccountLabels.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link AccountLabels.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(devices)
                .label(getLabel());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link AccountLabels}.
     */
    public static class Builder {
        private List<DeviceList> devices;
        private List<DeviceLabels> label;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  devices  List of DeviceList value for devices.
         */
        public Builder(List<DeviceList> devices) {
            this.devices = devices;
        }

        /**
         * Setter for devices.
         * @param  devices  List of DeviceList value for devices.
         * @return Builder
         */
        public Builder devices(List<DeviceList> devices) {
            this.devices = devices;
            return this;
        }

        /**
         * Setter for label.
         * @param  label  List of DeviceLabels value for label.
         * @return Builder
         */
        public Builder label(List<DeviceLabels> label) {
            this.label = label;
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
         * Builds a new {@link AccountLabels} object using the set fields.
         * @return {@link AccountLabels}
         */
        public AccountLabels build() {
            AccountLabels model =
                    new AccountLabels(devices, label);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
