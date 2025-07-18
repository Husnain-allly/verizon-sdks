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
import java.util.Map;

/**
 * This is a model class for MismatchedDevice type.
 */
public class MismatchedDevice {
    private String accountName;
    private String mdn;
    private String activationDate;
    private String iccid;
    private String preImei;
    private String postImei;
    private String simOtaDate;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public MismatchedDevice() {
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  mdn  String value for mdn.
     * @param  activationDate  String value for activationDate.
     * @param  iccid  String value for iccid.
     * @param  preImei  String value for preImei.
     * @param  postImei  String value for postImei.
     * @param  simOtaDate  String value for simOtaDate.
     */
    public MismatchedDevice(
            String accountName,
            String mdn,
            String activationDate,
            String iccid,
            String preImei,
            String postImei,
            String simOtaDate) {
        this.accountName = accountName;
        this.mdn = mdn;
        this.activationDate = activationDate;
        this.iccid = iccid;
        this.preImei = preImei;
        this.postImei = postImei;
        this.simOtaDate = simOtaDate;
    }

    /**
     * Getter for AccountName.
     * The account that the device is associated with.
     * @return Returns the String
     */
    @JsonGetter("accountName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * The account that the device is associated with.
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for Mdn.
     * The assigned phone number of the device.
     * @return Returns the String
     */
    @JsonGetter("mdn")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getMdn() {
        return mdn;
    }

    /**
     * Setter for Mdn.
     * The assigned phone number of the device.
     * @param mdn Value for String
     */
    @JsonSetter("mdn")
    public void setMdn(String mdn) {
        this.mdn = mdn;
    }

    /**
     * Getter for ActivationDate.
     * The date and time when the SIM was last activated.
     * @return Returns the String
     */
    @JsonGetter("activationDate")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getActivationDate() {
        return activationDate;
    }

    /**
     * Setter for ActivationDate.
     * The date and time when the SIM was last activated.
     * @param activationDate Value for String
     */
    @JsonSetter("activationDate")
    public void setActivationDate(String activationDate) {
        this.activationDate = activationDate;
    }

    /**
     * Getter for Iccid.
     * The ID of the SIM.
     * @return Returns the String
     */
    @JsonGetter("iccid")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getIccid() {
        return iccid;
    }

    /**
     * Setter for Iccid.
     * The ID of the SIM.
     * @param iccid Value for String
     */
    @JsonSetter("iccid")
    public void setIccid(String iccid) {
        this.iccid = iccid;
    }

    /**
     * Getter for PreImei.
     * The IMEI of the device prior to the SIM OTA activation on simOtaDate.
     * @return Returns the String
     */
    @JsonGetter("preImei")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getPreImei() {
        return preImei;
    }

    /**
     * Setter for PreImei.
     * The IMEI of the device prior to the SIM OTA activation on simOtaDate.
     * @param preImei Value for String
     */
    @JsonSetter("preImei")
    public void setPreImei(String preImei) {
        this.preImei = preImei;
    }

    /**
     * Getter for PostImei.
     * The IMEI of the device after the SIM OTA activation on simOtaDate.
     * @return Returns the String
     */
    @JsonGetter("postImei")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getPostImei() {
        return postImei;
    }

    /**
     * Setter for PostImei.
     * The IMEI of the device after the SIM OTA activation on simOtaDate.
     * @param postImei Value for String
     */
    @JsonSetter("postImei")
    public void setPostImei(String postImei) {
        this.postImei = postImei;
    }

    /**
     * Getter for SimOtaDate.
     * The date and time of the SIM OTA activation.
     * @return Returns the String
     */
    @JsonGetter("simOtaDate")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getSimOtaDate() {
        return simOtaDate;
    }

    /**
     * Setter for SimOtaDate.
     * The date and time of the SIM OTA activation.
     * @param simOtaDate Value for String
     */
    @JsonSetter("simOtaDate")
    public void setSimOtaDate(String simOtaDate) {
        this.simOtaDate = simOtaDate;
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
     * Converts this MismatchedDevice into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "MismatchedDevice [" + "accountName=" + accountName + ", mdn=" + mdn
                + ", activationDate=" + activationDate + ", iccid=" + iccid + ", preImei=" + preImei
                + ", postImei=" + postImei + ", simOtaDate=" + simOtaDate
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link MismatchedDevice.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link MismatchedDevice.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .accountName(getAccountName())
                .mdn(getMdn())
                .activationDate(getActivationDate())
                .iccid(getIccid())
                .preImei(getPreImei())
                .postImei(getPostImei())
                .simOtaDate(getSimOtaDate());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link MismatchedDevice}.
     */
    public static class Builder {
        private String accountName;
        private String mdn;
        private String activationDate;
        private String iccid;
        private String preImei;
        private String postImei;
        private String simOtaDate;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



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
         * Setter for mdn.
         * @param  mdn  String value for mdn.
         * @return Builder
         */
        public Builder mdn(String mdn) {
            this.mdn = mdn;
            return this;
        }

        /**
         * Setter for activationDate.
         * @param  activationDate  String value for activationDate.
         * @return Builder
         */
        public Builder activationDate(String activationDate) {
            this.activationDate = activationDate;
            return this;
        }

        /**
         * Setter for iccid.
         * @param  iccid  String value for iccid.
         * @return Builder
         */
        public Builder iccid(String iccid) {
            this.iccid = iccid;
            return this;
        }

        /**
         * Setter for preImei.
         * @param  preImei  String value for preImei.
         * @return Builder
         */
        public Builder preImei(String preImei) {
            this.preImei = preImei;
            return this;
        }

        /**
         * Setter for postImei.
         * @param  postImei  String value for postImei.
         * @return Builder
         */
        public Builder postImei(String postImei) {
            this.postImei = postImei;
            return this;
        }

        /**
         * Setter for simOtaDate.
         * @param  simOtaDate  String value for simOtaDate.
         * @return Builder
         */
        public Builder simOtaDate(String simOtaDate) {
            this.simOtaDate = simOtaDate;
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
         * Builds a new {@link MismatchedDevice} object using the set fields.
         * @return {@link MismatchedDevice}
         */
        public MismatchedDevice build() {
            MismatchedDevice model =
                    new MismatchedDevice(accountName, mdn, activationDate, iccid, preImei, postImei,
                            simOtaDate);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
