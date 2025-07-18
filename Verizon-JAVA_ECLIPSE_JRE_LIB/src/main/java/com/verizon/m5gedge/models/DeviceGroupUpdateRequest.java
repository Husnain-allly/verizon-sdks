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
 * This is a model class for DeviceGroupUpdateRequest type.
 */
public class DeviceGroupUpdateRequest {
    private List<DeviceId> devicesToAdd;
    private List<DeviceId> devicesToRemove;
    private String newGroupDescription;
    private String newGroupName;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public DeviceGroupUpdateRequest() {
    }

    /**
     * Initialization constructor.
     * @param  devicesToAdd  List of DeviceId value for devicesToAdd.
     * @param  devicesToRemove  List of DeviceId value for devicesToRemove.
     * @param  newGroupDescription  String value for newGroupDescription.
     * @param  newGroupName  String value for newGroupName.
     */
    public DeviceGroupUpdateRequest(
            List<DeviceId> devicesToAdd,
            List<DeviceId> devicesToRemove,
            String newGroupDescription,
            String newGroupName) {
        this.devicesToAdd = devicesToAdd;
        this.devicesToRemove = devicesToRemove;
        this.newGroupDescription = newGroupDescription;
        this.newGroupName = newGroupName;
    }

    /**
     * Getter for DevicesToAdd.
     * Zero or more devices to add to the device group, specified by device ID. The devices will be
     * removed from their current device groups. You can use POST /devices/actions/list to get a
     * list of all devices in the account.
     * @return Returns the List of DeviceId
     */
    @JsonGetter("devicesToAdd")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<DeviceId> getDevicesToAdd() {
        return devicesToAdd;
    }

    /**
     * Setter for DevicesToAdd.
     * Zero or more devices to add to the device group, specified by device ID. The devices will be
     * removed from their current device groups. You can use POST /devices/actions/list to get a
     * list of all devices in the account.
     * @param devicesToAdd Value for List of DeviceId
     */
    @JsonSetter("devicesToAdd")
    public void setDevicesToAdd(List<DeviceId> devicesToAdd) {
        this.devicesToAdd = devicesToAdd;
    }

    /**
     * Getter for DevicesToRemove.
     * Zero or more devices to remove from the device group, specified by device ID. The devices
     * will be added to the default device group.
     * @return Returns the List of DeviceId
     */
    @JsonGetter("devicesToRemove")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<DeviceId> getDevicesToRemove() {
        return devicesToRemove;
    }

    /**
     * Setter for DevicesToRemove.
     * Zero or more devices to remove from the device group, specified by device ID. The devices
     * will be added to the default device group.
     * @param devicesToRemove Value for List of DeviceId
     */
    @JsonSetter("devicesToRemove")
    public void setDevicesToRemove(List<DeviceId> devicesToRemove) {
        this.devicesToRemove = devicesToRemove;
    }

    /**
     * Getter for NewGroupDescription.
     * A new description for the device group. Do not include this parameter to leave the group
     * description unchanged.
     * @return Returns the String
     */
    @JsonGetter("newGroupDescription")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getNewGroupDescription() {
        return newGroupDescription;
    }

    /**
     * Setter for NewGroupDescription.
     * A new description for the device group. Do not include this parameter to leave the group
     * description unchanged.
     * @param newGroupDescription Value for String
     */
    @JsonSetter("newGroupDescription")
    public void setNewGroupDescription(String newGroupDescription) {
        this.newGroupDescription = newGroupDescription;
    }

    /**
     * Getter for NewGroupName.
     * A new name for the device group. Do not include this parameter if you want to leave the group
     * name unchanged.
     * @return Returns the String
     */
    @JsonGetter("newGroupName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getNewGroupName() {
        return newGroupName;
    }

    /**
     * Setter for NewGroupName.
     * A new name for the device group. Do not include this parameter if you want to leave the group
     * name unchanged.
     * @param newGroupName Value for String
     */
    @JsonSetter("newGroupName")
    public void setNewGroupName(String newGroupName) {
        this.newGroupName = newGroupName;
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
     * Converts this DeviceGroupUpdateRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DeviceGroupUpdateRequest [" + "devicesToAdd=" + devicesToAdd + ", devicesToRemove="
                + devicesToRemove + ", newGroupDescription=" + newGroupDescription
                + ", newGroupName=" + newGroupName + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link DeviceGroupUpdateRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DeviceGroupUpdateRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .devicesToAdd(getDevicesToAdd())
                .devicesToRemove(getDevicesToRemove())
                .newGroupDescription(getNewGroupDescription())
                .newGroupName(getNewGroupName());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link DeviceGroupUpdateRequest}.
     */
    public static class Builder {
        private List<DeviceId> devicesToAdd;
        private List<DeviceId> devicesToRemove;
        private String newGroupDescription;
        private String newGroupName;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for devicesToAdd.
         * @param  devicesToAdd  List of DeviceId value for devicesToAdd.
         * @return Builder
         */
        public Builder devicesToAdd(List<DeviceId> devicesToAdd) {
            this.devicesToAdd = devicesToAdd;
            return this;
        }

        /**
         * Setter for devicesToRemove.
         * @param  devicesToRemove  List of DeviceId value for devicesToRemove.
         * @return Builder
         */
        public Builder devicesToRemove(List<DeviceId> devicesToRemove) {
            this.devicesToRemove = devicesToRemove;
            return this;
        }

        /**
         * Setter for newGroupDescription.
         * @param  newGroupDescription  String value for newGroupDescription.
         * @return Builder
         */
        public Builder newGroupDescription(String newGroupDescription) {
            this.newGroupDescription = newGroupDescription;
            return this;
        }

        /**
         * Setter for newGroupName.
         * @param  newGroupName  String value for newGroupName.
         * @return Builder
         */
        public Builder newGroupName(String newGroupName) {
            this.newGroupName = newGroupName;
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
         * Builds a new {@link DeviceGroupUpdateRequest} object using the set fields.
         * @return {@link DeviceGroupUpdateRequest}
         */
        public DeviceGroupUpdateRequest build() {
            DeviceGroupUpdateRequest model =
                    new DeviceGroupUpdateRequest(devicesToAdd, devicesToRemove, newGroupDescription,
                            newGroupName);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
