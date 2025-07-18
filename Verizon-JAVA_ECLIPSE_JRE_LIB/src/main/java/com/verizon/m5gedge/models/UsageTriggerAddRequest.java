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
 * This is a model class for UsageTriggerAddRequest type.
 */
public class UsageTriggerAddRequest {
    private String triggerName;
    private String accountName;
    private ServiceName serviceName;
    private String thresholdValue;
    private Boolean allowExcess;
    private Boolean sendSmsNotification;
    private String smsPhoneNumbers;
    private Boolean sendEmailNotification;
    private String emailAddresses;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public UsageTriggerAddRequest() {
        serviceName = ServiceName.LOCATION;
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  serviceName  ServiceName value for serviceName.
     * @param  thresholdValue  String value for thresholdValue.
     * @param  triggerName  String value for triggerName.
     * @param  allowExcess  Boolean value for allowExcess.
     * @param  sendSmsNotification  Boolean value for sendSmsNotification.
     * @param  smsPhoneNumbers  String value for smsPhoneNumbers.
     * @param  sendEmailNotification  Boolean value for sendEmailNotification.
     * @param  emailAddresses  String value for emailAddresses.
     */
    public UsageTriggerAddRequest(
            String accountName,
            ServiceName serviceName,
            String thresholdValue,
            String triggerName,
            Boolean allowExcess,
            Boolean sendSmsNotification,
            String smsPhoneNumbers,
            Boolean sendEmailNotification,
            String emailAddresses) {
        this.triggerName = triggerName;
        this.accountName = accountName;
        this.serviceName = serviceName;
        this.thresholdValue = thresholdValue;
        this.allowExcess = allowExcess;
        this.sendSmsNotification = sendSmsNotification;
        this.smsPhoneNumbers = smsPhoneNumbers;
        this.sendEmailNotification = sendEmailNotification;
        this.emailAddresses = emailAddresses;
    }

    /**
     * Getter for TriggerName.
     * Usage trigger name
     * @return Returns the String
     */
    @JsonGetter("triggerName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getTriggerName() {
        return triggerName;
    }

    /**
     * Setter for TriggerName.
     * Usage trigger name
     * @param triggerName Value for String
     */
    @JsonSetter("triggerName")
    public void setTriggerName(String triggerName) {
        this.triggerName = triggerName;
    }

    /**
     * Getter for AccountName.
     * Account name
     * @return Returns the String
     */
    @JsonGetter("accountName")
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * Account name
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for ServiceName.
     * Service name
     * @return Returns the ServiceName
     */
    @JsonGetter("serviceName")
    public ServiceName getServiceName() {
        return serviceName;
    }

    /**
     * Setter for ServiceName.
     * Service name
     * @param serviceName Value for ServiceName
     */
    @JsonSetter("serviceName")
    public void setServiceName(ServiceName serviceName) {
        this.serviceName = serviceName;
    }

    /**
     * Getter for ThresholdValue.
     * The percent of subscribed usage required to activate the trigger, such as 90 or 100.
     * @return Returns the String
     */
    @JsonGetter("thresholdValue")
    public String getThresholdValue() {
        return thresholdValue;
    }

    /**
     * Setter for ThresholdValue.
     * The percent of subscribed usage required to activate the trigger, such as 90 or 100.
     * @param thresholdValue Value for String
     */
    @JsonSetter("thresholdValue")
    public void setThresholdValue(String thresholdValue) {
        this.thresholdValue = thresholdValue;
    }

    /**
     * Getter for AllowExcess.
     * Allow additional requests after thresholdValue is reached. (currently not functional)
     * @return Returns the Boolean
     */
    @JsonGetter("allowExcess")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Boolean getAllowExcess() {
        return allowExcess;
    }

    /**
     * Setter for AllowExcess.
     * Allow additional requests after thresholdValue is reached. (currently not functional)
     * @param allowExcess Value for Boolean
     */
    @JsonSetter("allowExcess")
    public void setAllowExcess(Boolean allowExcess) {
        this.allowExcess = allowExcess;
    }

    /**
     * Getter for SendSmsNotification.
     * Send SMS (text) alerts when the thresholdValue is reached.
     * @return Returns the Boolean
     */
    @JsonGetter("sendSmsNotification")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Boolean getSendSmsNotification() {
        return sendSmsNotification;
    }

    /**
     * Setter for SendSmsNotification.
     * Send SMS (text) alerts when the thresholdValue is reached.
     * @param sendSmsNotification Value for Boolean
     */
    @JsonSetter("sendSmsNotification")
    public void setSendSmsNotification(Boolean sendSmsNotification) {
        this.sendSmsNotification = sendSmsNotification;
    }

    /**
     * Getter for SmsPhoneNumbers.
     * Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or
     * parentheses, etc.
     * @return Returns the String
     */
    @JsonGetter("smsPhoneNumbers")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getSmsPhoneNumbers() {
        return smsPhoneNumbers;
    }

    /**
     * Setter for SmsPhoneNumbers.
     * Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or
     * parentheses, etc.
     * @param smsPhoneNumbers Value for String
     */
    @JsonSetter("smsPhoneNumbers")
    public void setSmsPhoneNumbers(String smsPhoneNumbers) {
        this.smsPhoneNumbers = smsPhoneNumbers;
    }

    /**
     * Getter for SendEmailNotification.
     * Send email alerts when the thresholdValue is reached.
     * @return Returns the Boolean
     */
    @JsonGetter("sendEmailNotification")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Boolean getSendEmailNotification() {
        return sendEmailNotification;
    }

    /**
     * Setter for SendEmailNotification.
     * Send email alerts when the thresholdValue is reached.
     * @param sendEmailNotification Value for Boolean
     */
    @JsonSetter("sendEmailNotification")
    public void setSendEmailNotification(Boolean sendEmailNotification) {
        this.sendEmailNotification = sendEmailNotification;
    }

    /**
     * Getter for EmailAddresses.
     * Comma-separated list of email addresses to send alerts to.
     * @return Returns the String
     */
    @JsonGetter("emailAddresses")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getEmailAddresses() {
        return emailAddresses;
    }

    /**
     * Setter for EmailAddresses.
     * Comma-separated list of email addresses to send alerts to.
     * @param emailAddresses Value for String
     */
    @JsonSetter("emailAddresses")
    public void setEmailAddresses(String emailAddresses) {
        this.emailAddresses = emailAddresses;
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
     * Converts this UsageTriggerAddRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "UsageTriggerAddRequest [" + "accountName=" + accountName + ", serviceName="
                + serviceName + ", thresholdValue=" + thresholdValue + ", triggerName="
                + triggerName + ", allowExcess=" + allowExcess + ", sendSmsNotification="
                + sendSmsNotification + ", smsPhoneNumbers=" + smsPhoneNumbers
                + ", sendEmailNotification=" + sendEmailNotification + ", emailAddresses="
                + emailAddresses + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link UsageTriggerAddRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link UsageTriggerAddRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(accountName, serviceName, thresholdValue)
                .triggerName(getTriggerName())
                .allowExcess(getAllowExcess())
                .sendSmsNotification(getSendSmsNotification())
                .smsPhoneNumbers(getSmsPhoneNumbers())
                .sendEmailNotification(getSendEmailNotification())
                .emailAddresses(getEmailAddresses());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link UsageTriggerAddRequest}.
     */
    public static class Builder {
        private String accountName;
        private ServiceName serviceName = ServiceName.LOCATION;
        private String thresholdValue;
        private String triggerName;
        private Boolean allowExcess;
        private Boolean sendSmsNotification;
        private String smsPhoneNumbers;
        private Boolean sendEmailNotification;
        private String emailAddresses;
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
         * @param  serviceName  ServiceName value for serviceName.
         * @param  thresholdValue  String value for thresholdValue.
         */
        public Builder(String accountName, ServiceName serviceName, String thresholdValue) {
            this.accountName = accountName;
            this.serviceName = serviceName;
            this.thresholdValue = thresholdValue;
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
         * Setter for serviceName.
         * @param  serviceName  ServiceName value for serviceName.
         * @return Builder
         */
        public Builder serviceName(ServiceName serviceName) {
            this.serviceName = serviceName;
            return this;
        }

        /**
         * Setter for thresholdValue.
         * @param  thresholdValue  String value for thresholdValue.
         * @return Builder
         */
        public Builder thresholdValue(String thresholdValue) {
            this.thresholdValue = thresholdValue;
            return this;
        }

        /**
         * Setter for triggerName.
         * @param  triggerName  String value for triggerName.
         * @return Builder
         */
        public Builder triggerName(String triggerName) {
            this.triggerName = triggerName;
            return this;
        }

        /**
         * Setter for allowExcess.
         * @param  allowExcess  Boolean value for allowExcess.
         * @return Builder
         */
        public Builder allowExcess(Boolean allowExcess) {
            this.allowExcess = allowExcess;
            return this;
        }

        /**
         * Setter for sendSmsNotification.
         * @param  sendSmsNotification  Boolean value for sendSmsNotification.
         * @return Builder
         */
        public Builder sendSmsNotification(Boolean sendSmsNotification) {
            this.sendSmsNotification = sendSmsNotification;
            return this;
        }

        /**
         * Setter for smsPhoneNumbers.
         * @param  smsPhoneNumbers  String value for smsPhoneNumbers.
         * @return Builder
         */
        public Builder smsPhoneNumbers(String smsPhoneNumbers) {
            this.smsPhoneNumbers = smsPhoneNumbers;
            return this;
        }

        /**
         * Setter for sendEmailNotification.
         * @param  sendEmailNotification  Boolean value for sendEmailNotification.
         * @return Builder
         */
        public Builder sendEmailNotification(Boolean sendEmailNotification) {
            this.sendEmailNotification = sendEmailNotification;
            return this;
        }

        /**
         * Setter for emailAddresses.
         * @param  emailAddresses  String value for emailAddresses.
         * @return Builder
         */
        public Builder emailAddresses(String emailAddresses) {
            this.emailAddresses = emailAddresses;
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
         * Builds a new {@link UsageTriggerAddRequest} object using the set fields.
         * @return {@link UsageTriggerAddRequest}
         */
        public UsageTriggerAddRequest build() {
            UsageTriggerAddRequest model =
                    new UsageTriggerAddRequest(accountName, serviceName, thresholdValue,
                            triggerName, allowExcess, sendSmsNotification, smsPhoneNumbers,
                            sendEmailNotification, emailAddresses);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
