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
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;
import com.fasterxml.jackson.databind.annotation.JsonSerialize;
import com.verizon.m5gedge.DateTimeHelper;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.time.LocalDateTime;
import java.util.Map;

/**
 * This is a model class for DiagnosticsSubscription type.
 */
public class DiagnosticsSubscription {
    private String accountName;
    private LocalDateTime createdOn;
    private LocalDateTime lastUpdated;
    private int totalAllowed;
    private int totalUsed;
    private String skuName;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public DiagnosticsSubscription() {
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  createdOn  LocalDateTime value for createdOn.
     * @param  lastUpdated  LocalDateTime value for lastUpdated.
     * @param  totalAllowed  int value for totalAllowed.
     * @param  totalUsed  int value for totalUsed.
     * @param  skuName  String value for skuName.
     */
    public DiagnosticsSubscription(
            String accountName,
            LocalDateTime createdOn,
            LocalDateTime lastUpdated,
            int totalAllowed,
            int totalUsed,
            String skuName) {
        this.accountName = accountName;
        this.createdOn = createdOn;
        this.lastUpdated = lastUpdated;
        this.totalAllowed = totalAllowed;
        this.totalUsed = totalUsed;
        this.skuName = skuName;
    }

    /**
     * Getter for AccountName.
     * Account identifier in "##########-#####". An account name is usually numeric, and must
     * include any leading zeros.
     * @return Returns the String
     */
    @JsonGetter("accountName")
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * Account identifier in "##########-#####". An account name is usually numeric, and must
     * include any leading zeros.
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for CreatedOn.
     * The date and time of when the subscription was created.
     * @return Returns the LocalDateTime
     */
    @JsonGetter("createdOn")
    @JsonSerialize(using = DateTimeHelper.Rfc8601DateTimeSerializer.class)
    public LocalDateTime getCreatedOn() {
        return createdOn;
    }

    /**
     * Setter for CreatedOn.
     * The date and time of when the subscription was created.
     * @param createdOn Value for LocalDateTime
     */
    @JsonSetter("createdOn")
    @JsonDeserialize(using = DateTimeHelper.Rfc8601DateTimeDeserializer.class)
    public void setCreatedOn(LocalDateTime createdOn) {
        this.createdOn = createdOn;
    }

    /**
     * Getter for LastUpdated.
     * The date and time of when the subscription was last updated.
     * @return Returns the LocalDateTime
     */
    @JsonGetter("lastUpdated")
    @JsonSerialize(using = DateTimeHelper.Rfc8601DateTimeSerializer.class)
    public LocalDateTime getLastUpdated() {
        return lastUpdated;
    }

    /**
     * Setter for LastUpdated.
     * The date and time of when the subscription was last updated.
     * @param lastUpdated Value for LocalDateTime
     */
    @JsonSetter("lastUpdated")
    @JsonDeserialize(using = DateTimeHelper.Rfc8601DateTimeDeserializer.class)
    public void setLastUpdated(LocalDateTime lastUpdated) {
        this.lastUpdated = lastUpdated;
    }

    /**
     * Getter for TotalAllowed.
     * Number of licenses currently assigned to devices.
     * @return Returns the int
     */
    @JsonGetter("totalAllowed")
    public int getTotalAllowed() {
        return totalAllowed;
    }

    /**
     * Setter for TotalAllowed.
     * Number of licenses currently assigned to devices.
     * @param totalAllowed Value for int
     */
    @JsonSetter("totalAllowed")
    public void setTotalAllowed(int totalAllowed) {
        this.totalAllowed = totalAllowed;
    }

    /**
     * Getter for TotalUsed.
     * Number of licenses currently used by the devices.
     * @return Returns the int
     */
    @JsonGetter("totalUsed")
    public int getTotalUsed() {
        return totalUsed;
    }

    /**
     * Setter for TotalUsed.
     * Number of licenses currently used by the devices.
     * @param totalUsed Value for int
     */
    @JsonSetter("totalUsed")
    public void setTotalUsed(int totalUsed) {
        this.totalUsed = totalUsed;
    }

    /**
     * Getter for SkuName.
     * Name of the SKU for the account.
     * @return Returns the String
     */
    @JsonGetter("skuName")
    public String getSkuName() {
        return skuName;
    }

    /**
     * Setter for SkuName.
     * Name of the SKU for the account.
     * @param skuName Value for String
     */
    @JsonSetter("skuName")
    public void setSkuName(String skuName) {
        this.skuName = skuName;
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
     * Converts this DiagnosticsSubscription into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DiagnosticsSubscription [" + "accountName=" + accountName + ", createdOn="
                + createdOn + ", lastUpdated=" + lastUpdated + ", totalAllowed=" + totalAllowed
                + ", totalUsed=" + totalUsed + ", skuName=" + skuName + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link DiagnosticsSubscription.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DiagnosticsSubscription.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(accountName, createdOn, lastUpdated, totalAllowed, totalUsed,
                skuName);
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link DiagnosticsSubscription}.
     */
    public static class Builder {
        private String accountName;
        private LocalDateTime createdOn;
        private LocalDateTime lastUpdated;
        private int totalAllowed;
        private int totalUsed;
        private String skuName;
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
         * @param  createdOn  LocalDateTime value for createdOn.
         * @param  lastUpdated  LocalDateTime value for lastUpdated.
         * @param  totalAllowed  int value for totalAllowed.
         * @param  totalUsed  int value for totalUsed.
         * @param  skuName  String value for skuName.
         */
        public Builder(String accountName, LocalDateTime createdOn, LocalDateTime lastUpdated,
                int totalAllowed, int totalUsed, String skuName) {
            this.accountName = accountName;
            this.createdOn = createdOn;
            this.lastUpdated = lastUpdated;
            this.totalAllowed = totalAllowed;
            this.totalUsed = totalUsed;
            this.skuName = skuName;
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
         * Setter for createdOn.
         * @param  createdOn  LocalDateTime value for createdOn.
         * @return Builder
         */
        public Builder createdOn(LocalDateTime createdOn) {
            this.createdOn = createdOn;
            return this;
        }

        /**
         * Setter for lastUpdated.
         * @param  lastUpdated  LocalDateTime value for lastUpdated.
         * @return Builder
         */
        public Builder lastUpdated(LocalDateTime lastUpdated) {
            this.lastUpdated = lastUpdated;
            return this;
        }

        /**
         * Setter for totalAllowed.
         * @param  totalAllowed  int value for totalAllowed.
         * @return Builder
         */
        public Builder totalAllowed(int totalAllowed) {
            this.totalAllowed = totalAllowed;
            return this;
        }

        /**
         * Setter for totalUsed.
         * @param  totalUsed  int value for totalUsed.
         * @return Builder
         */
        public Builder totalUsed(int totalUsed) {
            this.totalUsed = totalUsed;
            return this;
        }

        /**
         * Setter for skuName.
         * @param  skuName  String value for skuName.
         * @return Builder
         */
        public Builder skuName(String skuName) {
            this.skuName = skuName;
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
         * Builds a new {@link DiagnosticsSubscription} object using the set fields.
         * @return {@link DiagnosticsSubscription}
         */
        public DiagnosticsSubscription build() {
            DiagnosticsSubscription model =
                    new DiagnosticsSubscription(accountName, createdOn, lastUpdated, totalAllowed,
                            totalUsed, skuName);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
