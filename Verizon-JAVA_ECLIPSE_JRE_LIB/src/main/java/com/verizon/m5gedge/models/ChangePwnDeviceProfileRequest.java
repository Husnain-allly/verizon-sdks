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
 * This is a model class for ChangePwnDeviceProfileRequest type.
 */
public class ChangePwnDeviceProfileRequest {
    private String accountName;
    private List<PwnDeviceList> deviceList;
    private String newProfile;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public ChangePwnDeviceProfileRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  deviceList  List of PwnDeviceList value for deviceList.
     * @param  newProfile  String value for newProfile.
     */
    public ChangePwnDeviceProfileRequest(
            String accountName,
            List<PwnDeviceList> deviceList,
            String newProfile) {
        this.accountName = accountName;
        this.deviceList = deviceList;
        this.newProfile = newProfile;
    }

    /**
     * Getter for AccountName.
     * @return Returns the String
     */
    @JsonGetter("accountName")
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for DeviceList.
     * @return Returns the List of PwnDeviceList
     */
    @JsonGetter("deviceList")
    public List<PwnDeviceList> getDeviceList() {
        return deviceList;
    }

    /**
     * Setter for DeviceList.
     * @param deviceList Value for List of PwnDeviceList
     */
    @JsonSetter("deviceList")
    public void setDeviceList(List<PwnDeviceList> deviceList) {
        this.deviceList = deviceList;
    }

    /**
     * Getter for NewProfile.
     * @return Returns the String
     */
    @JsonGetter("newProfile")
    public String getNewProfile() {
        return newProfile;
    }

    /**
     * Setter for NewProfile.
     * @param newProfile Value for String
     */
    @JsonSetter("newProfile")
    public void setNewProfile(String newProfile) {
        this.newProfile = newProfile;
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
     * Converts this ChangePwnDeviceProfileRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "ChangePwnDeviceProfileRequest [" + "accountName=" + accountName + ", deviceList="
                + deviceList + ", newProfile=" + newProfile + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link ChangePwnDeviceProfileRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link ChangePwnDeviceProfileRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(accountName, deviceList, newProfile);
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link ChangePwnDeviceProfileRequest}.
     */
    public static class Builder {
        private String accountName;
        private List<PwnDeviceList> deviceList;
        private String newProfile;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  accountName  String value for accountName.
         * @param  deviceList  List of PwnDeviceList value for deviceList.
         * @param  newProfile  String value for newProfile.
         */
        public Builder(String accountName, List<PwnDeviceList> deviceList, String newProfile) {
            this.accountName = accountName;
            this.deviceList = deviceList;
            this.newProfile = newProfile;
        }

        /**
         * Setter for accountName.
         * @param  accountName  String value for accountName.
         * @return Builder
         */
        public Builder accountName(String accountName) {
            this.accountName = accountName;
            return this;
        }

        /**
         * Setter for deviceList.
         * @param  deviceList  List of PwnDeviceList value for deviceList.
         * @return Builder
         */
        public Builder deviceList(List<PwnDeviceList> deviceList) {
            this.deviceList = deviceList;
            return this;
        }

        /**
         * Setter for newProfile.
         * @param  newProfile  String value for newProfile.
         * @return Builder
         */
        public Builder newProfile(String newProfile) {
            this.newProfile = newProfile;
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
         * Builds a new {@link ChangePwnDeviceProfileRequest} object using the set fields.
         * @return {@link ChangePwnDeviceProfileRequest}
         */
        public ChangePwnDeviceProfileRequest build() {
            ChangePwnDeviceProfileRequest model =
                    new ChangePwnDeviceProfileRequest(accountName, deviceList, newProfile);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
