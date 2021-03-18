# EDD
Enumerate Domain Data

## Functions

getdomaincomputers - Get a list of all computers in the domain

getdomaincontrollers - Gets a list of all domain controllers

getnetlocalgroupmember - Returns a list of all users in a local group on a remote system

getnetdomaingroupmember - Returns a list of all users in a domain group

getdomainshares - Get a list of all accessible domain shares

finddomainprocess - Search for a specific process across all systems in the domain (requires admin access on remote systems)

getdomainusers - Get a list of all domains users

getdomainuser - Retrieves info about specific user (name, description, SID, Domain Groups)

getnetsession - Returns a list of accounts with sessions on the targeted system

getnetloggedon - Returns a list of accounts logged into the targeted system

finddomainuser - Searches the domain environment for a specified user or group and tries to find active sessions (default searches for Domain Admins)

getdomainsid - Returns the domain sid (by default current domain if no domain is provided)
