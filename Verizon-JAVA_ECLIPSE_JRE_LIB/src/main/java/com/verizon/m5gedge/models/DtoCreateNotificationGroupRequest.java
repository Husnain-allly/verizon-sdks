/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;
import java.util.List;

/**
 * This is a model class for DtoCreateNotificationGroupRequest type.
 */
public class DtoCreateNotificationGroupRequest {
    private String accountname;
    private DtoNotificationGroupRequestEntity group;
    private List<String> userids;

    /**
     * Default constructor.
     */
    public DtoCreateNotificationGroupRequest() {
    }

    /**
     * Initialization constructor.
     * @param  group  DtoNotificationGroupRequestEntity value for group.
     * @param  accountname  String value for accountname.
     * @param  userids  List of String value for userids.
     */
    public DtoCreateNotificationGroupRequest(
            DtoNotificationGroupRequestEntity group,
            String accountname,
            List<String> userids) {
        this.accountname = accountname;
        this.group = group;
        this.userids = userids;
    }

    /**
     * Getter for Accountname.
     * The numeric account name, which must include leading zeros
     * @return Returns the String
     */
    @JsonGetter("accountname")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAccountname() {
        return accountname;
    }

    /**
     * Setter for Accountname.
     * The numeric account name, which must include leading zeros
     * @param accountname Value for String
     */
    @JsonSetter("accountname")
    public void setAccountname(String accountname) {
        this.accountname = accountname;
    }

    /**
     * Getter for Group.
     * @return Returns the DtoNotificationGroupRequestEntity
     */
    @JsonGetter("group")
    public DtoNotificationGroupRequestEntity getGroup() {
        return group;
    }

    /**
     * Setter for Group.
     * @param group Value for DtoNotificationGroupRequestEntity
     */
    @JsonSetter("group")
    public void setGroup(DtoNotificationGroupRequestEntity group) {
        this.group = group;
    }

    /**
     * Getter for Userids.
     * @return Returns the List of String
     */
    @JsonGetter("userids")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<String> getUserids() {
        return userids;
    }

    /**
     * Setter for Userids.
     * @param userids Value for List of String
     */
    @JsonSetter("userids")
    public void setUserids(List<String> userids) {
        this.userids = userids;
    }

    /**
     * Converts this DtoCreateNotificationGroupRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DtoCreateNotificationGroupRequest [" + "group=" + group + ", accountname="
                + accountname + ", userids=" + userids + "]";
    }

    /**
     * Builds a new {@link DtoCreateNotificationGroupRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DtoCreateNotificationGroupRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(group)
                .accountname(getAccountname())
                .userids(getUserids());
        return builder;
    }

    /**
     * Class to build instances of {@link DtoCreateNotificationGroupRequest}.
     */
    public static class Builder {
        private DtoNotificationGroupRequestEntity group;
        private String accountname;
        private List<String> userids;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  group  DtoNotificationGroupRequestEntity value for group.
         */
        public Builder(DtoNotificationGroupRequestEntity group) {
            this.group = group;
        }

        /**
         * Setter for group.
         * @param  group  DtoNotificationGroupRequestEntity value for group.
         * @return Builder
         */
        public Builder group(DtoNotificationGroupRequestEntity group) {
            this.group = group;
            return this;
        }

        /**
         * Setter for accountname.
         * @param  accountname  String value for accountname.
         * @return Builder
         */
        public Builder accountname(String accountname) {
            this.accountname = accountname;
            return this;
        }

        /**
         * Setter for userids.
         * @param  userids  List of String value for userids.
         * @return Builder
         */
        public Builder userids(List<String> userids) {
            this.userids = userids;
            return this;
        }

        /**
         * Builds a new {@link DtoCreateNotificationGroupRequest} object using the set fields.
         * @return {@link DtoCreateNotificationGroupRequest}
         */
        public DtoCreateNotificationGroupRequest build() {
            return new DtoCreateNotificationGroupRequest(group, accountname, userids);
        }
    }
}
