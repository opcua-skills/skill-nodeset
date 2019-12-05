# OPC UA Skill Model

[![Build Status](https://cloud.drone.io/api/badges/Pro/opcua-device-skills/status.svg)](https://cloud.drone.io/Pro/opcua-device-skills)

This repository contains the Model.xml files for the OPC UA Skill Model developed inside the SOArc VDMA Companion Specification Group.

Further details on the Model.xml format can be found here:
https://opcua.rocks/custom-information-models/

The model is based on the publication:

S. Profanter, A. Breitkreuz, M. Rickert, and A. Knoll, "A Hardware-Agnostic OPC UA Skill Model for Robot Manipulators and Tools,"
in Proceedings of the IEEE International Conference on Emerging Technologies And Factory Automation (ETFA), Zaragoza, Spain, Sep. 2019

The full-text PDF is available here: https://mediatum.ub.tum.de/1507596

## Will this model be supported by the OPC Foundation?

This model is part of the official VDMA and OPC Foundation joint working group for a skill concept which can be used inside OPC UA.

[Service-Oriented Architectures and real-time Control (SOArc)](https://www.th-owl.de/init/aktuelles/news/news-detail/news/kick-off-meeting-vdma-arbeitsgruppe-service-orientierte-architekturen-und-real-time-control-soarc.html)

This repository is a first draft of a possible skill model, which acts as a basis for further improvement inside the working group.

## How to use

The `master` branch only contains the `*Model.xml` files, not the compiled NodeSet2.xml files.

On every push to a branch, an is executed and the resultin model files are pushed back to the branch 'master-published'.

Have a look at the resulting files here:
https://github.com/opcua-skills/skill-nodeset/tree/master-published/Published

If you like to manually build the files on your machine, follow these steps:

This build process is using a pre-built docker container based on the official UA-ModelCompiler source code.
There's currently an open pull-request (https://github.com/OPCFoundation/UA-ModelCompiler/pull/36) to add the necessary docker files to the official repository. In the meantime you can use my docker container:
[sailavid/ua-modelcompiler](https://cloud.docker.com/u/sailavid/repository/docker/sailavid/ua-modelcompiler).

1. Install docker on your machine
2. Clone this repository
3. `cd skill-nodeset`
4. Then run the docker container for `skillModel`:
	```bash
	docker run \
		  --mount type=bind,source=$(pwd),target=/model/src \
		  --entrypoint "/app/PublishModel.sh" \
		  sailavid/ua-modelcompiler \
		   /model/src/SkillsModel Opc.Ua.Skills /model/src/Published
	```
5. To build an example, run the following:
	```bash
	docker run \
		  --mount type=bind,source=$(pwd),target=/model/src \
		  --entrypoint "/app/PublishModel.sh" \
		  sailavid/ua-modelcompiler \
		   /model/src/exampleModel/LinearAxisWithGripperModel Example.LinearAxisWithGripper /model/src/Examples
	```

This will create all the compiled NodeSet2.xml files inside the `Published` folder.
With this command you can also compiler your own model files, just adapt the last line accordingly.